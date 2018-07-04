using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DesktopDoctor
{
    public partial class ReceptionForm : Form
    {
        Reception reception;
        public List<Medicine> medicines;

        public ReceptionForm(MainForm mainForm, Reception reception)
        {
            InitializeComponent();
            MdiParent = mainForm;
            this.reception = reception;
            if (reception.Id == 0)
            {
                reception.Date = DateTime.Now.Date;
            }
            dateLabel.Text = reception.Date.ToShortDateString();
            doctorLabel.Text = reception.Employee.ToString();
            patientLabel.Text = reception.Patient.ToString();
            temperatureTextBox.Text = reception.Temperature.ToString();
            pressureTextBox.Text = reception.Pressure == null ? "" : reception.Pressure.ToString();
            diagnosisTextBox.Text = reception.Diagnosis == null ? "" : reception.Diagnosis.ToString();
            symptomsTextBox.Text = reception.Symptoms == null ? "" : reception.Symptoms.ToString();
            recommendationsTextBox.Text = reception.Recommendations == null ? "" : reception.Recommendations.ToString();
            medicines = new List<Medicine>();
            foreach (ReceptionMedicine recMed in reception.ReceptionsMedicines)
            {
                medicines.Add(recMed.Medicine);
            }
            medicineBindingSource.DataSource = medicines;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToPatientForm(reception.Patient);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
            (MdiParent as MainForm).GoToPatientForm(reception.Patient);
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            SelectMedicineForm selectMedicineForm = new SelectMedicineForm(this);
            selectMedicineForm.ShowDialog();
        }

        public void AddMedicine(Medicine medicine)
        {
            medicines.Add(medicine);
            medicineBindingSource.CurrencyManager.Refresh();
        }

        private void RemoveMedicineButton_Click(object sender, EventArgs e)
        {
            if (medicines.Count > 0)
            {
                Medicine medicine = medicineBindingSource.Current as Medicine;
                medicines.Remove(medicine);
                medicineBindingSource.CurrencyManager.Refresh();
            }
        }

        private void Save()
        {
            if (Double.TryParse(temperatureTextBox.Text.ToString(), out double temperature))
            {
                reception.Temperature = temperature;
            }
            else
            {
                reception.Temperature = null;
            }
            reception.Pressure = pressureTextBox.Text.ToString();
            reception.Diagnosis = diagnosisTextBox.Text.ToString();
            reception.Symptoms = symptomsTextBox.Text.ToString();
            reception.Recommendations = recommendationsTextBox.Text.ToString();
            if (reception.Id == 0)
            {
                (MdiParent as MainForm).db.Receptions.Add(reception);
            }
            else
            {
                (MdiParent as MainForm).db.Entry(reception).State = EntityState.Modified;
            }
            (MdiParent as MainForm).db.SaveChanges();
            List<Medicine> linkedMedicines = new List<Medicine>();
            List<ReceptionMedicine> linkedReceptionMedicines = reception.ReceptionsMedicines.ToList();
            foreach (ReceptionMedicine recMed in linkedReceptionMedicines)
            {
                if (!medicines.Contains(recMed.Medicine))
                {
                    (MdiParent as MainForm).db.ReceptionsMedicines.Remove(recMed);
                    (MdiParent as MainForm).db.SaveChanges();
                }
                else
                {
                    linkedMedicines.Add(recMed.Medicine);
                }
            }
            foreach (Medicine med in medicines)
            {
                if (!linkedMedicines.Contains(med))
                {
                    ReceptionMedicine recMed = new ReceptionMedicine()
                    {
                        MedicineId = med.Id,
                        ReceptionId = reception.Id
                    };
                    (MdiParent as MainForm).db.ReceptionsMedicines.Add(recMed);
                    (MdiParent as MainForm).db.SaveChanges();
                }
            }
        }

        private void SaveRecomendationsButton_Click(object sender, EventArgs e)
        {
            Save();
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Document|*.docx",
                Title = "Сохранить рекомендации",
                FileName = reception.Date.ToShortDateString() + " " + reception.Patient.ToString() + " рекомендации"
            };
            saveFileDialog.ShowDialog();
            try
            {
                if (saveFileDialog.FileName != "")
                {
                    using (FileStream fileStream = saveFileDialog.OpenFile() as FileStream)
                    {
                        using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(fileStream, WordprocessingDocumentType.Document, true))
                        {
                            MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                            mainPart.Document = new Document();
                            Body body = new Body();
                            mainPart.Document.Body = body;
                            body.Append(new Paragraph(new OpenXmlElement[] {
                                new Run(new Text("Врач: ")
                                {
                                    Space = SpaceProcessingModeValues.Preserve
                                })
                                {
                                    RunProperties = new RunProperties()
                                    {
                                        Bold = new Bold()
                                        {
                                            Val = new OnOffValue(true)
                                        }
                                    }
                                },
                                new Run(new Text(reception.Employee.ToString())
                                {
                                     Space = SpaceProcessingModeValues.Preserve
                                })
                            }));
                            body.Append(new Paragraph(new OpenXmlElement[] {
                                new Run(new Text("Дата: ")
                                {
                                    Space = SpaceProcessingModeValues.Preserve
                                })
                                {
                                    RunProperties = new RunProperties()
                                    {
                                        Bold = new Bold()
                                        {
                                            Val = new OnOffValue(true)
                                        }
                                    }
                                },
                                new Run(new Text(reception.Date.ToShortDateString())
                                {
                                    Space = SpaceProcessingModeValues.Preserve
                                })
                            }));
                            body.Append(new Paragraph(new Run(new Text("Рекомендации:"))
                            {
                                RunProperties = new RunProperties()
                                {
                                    Bold = new Bold()
                                    {
                                        Val = new OnOffValue(true)
                                    }
                                }
                            }));
                            body.Append(new Paragraph(new Run(new Text(reception.Recommendations.ToString().Length == 0 ? "Нет" : reception.Recommendations.ToString()))));
                            if (reception.ReceptionsMedicines.Count > 0)
                            {
                                body.Append(new Paragraph(new Run(new Text("Медикаменты:"))
                                {
                                    RunProperties = new RunProperties()
                                    {
                                        Bold = new Bold()
                                        {
                                            Val = new OnOffValue(true)
                                        }
                                    }
                                }));
                                Table table = new Table();
                                TableProperties tableProperties = new TableProperties(
                                    new TableBorders(
                                        new TopBorder()
                                        {
                                            Val =
                                            new EnumValue<BorderValues>(BorderValues.Single),
                                            Size = 1
                                        },
                                        new BottomBorder()
                                        {
                                            Val =
                                            new EnumValue<BorderValues>(BorderValues.Single),
                                            Size = 1
                                        },
                                        new LeftBorder()
                                        {
                                            Val =
                                            new EnumValue<BorderValues>(BorderValues.Single),
                                            Size = 1
                                        },
                                        new RightBorder()
                                        {
                                            Val =
                                            new EnumValue<BorderValues>(BorderValues.Single),
                                            Size = 1
                                        },
                                        new InsideHorizontalBorder()
                                        {
                                            Val =
                                            new EnumValue<BorderValues>(BorderValues.Single),
                                            Size = 1
                                        },
                                        new InsideVerticalBorder()
                                        {
                                            Val =
                                            new EnumValue<BorderValues>(BorderValues.Single),
                                            Size = 1
                                        }
                                    )
                                );
                                table.AppendChild(tableProperties);
                                TableRow headerTableRow = new TableRow();
                                TableCell nameHeaderCell = new TableCell(new Paragraph(new Run(new Text("Название"))
                                {
                                    RunProperties = new RunProperties()
                                    {
                                        Bold = new Bold()
                                        {
                                            Val = new OnOffValue(true)
                                        }
                                    }
                                })
                                {
                                    ParagraphProperties = new ParagraphProperties()
                                    {
                                        Justification = new Justification()
                                        {
                                            Val = JustificationValues.Center
                                        }
                                    }
                                });
                                nameHeaderCell.Append(new TableCellProperties()
                                {
                                    TableCellVerticalAlignment = new TableCellVerticalAlignment()
                                    {
                                        Val = TableVerticalAlignmentValues.Center
                                    },
                                    TableCellWidth = new TableCellWidth()
                                    {
                                        Width = "3400"
                                    }
                                });
                                headerTableRow.Append(nameHeaderCell);
                                TableCell descriptionHeaderCell = new TableCell(new Paragraph(new Run(new Text("Описание"))
                                {
                                    RunProperties = new RunProperties()
                                    {
                                        Bold = new Bold()
                                        {
                                            Val = new OnOffValue(true)
                                        }
                                    }
                                })
                                {
                                    ParagraphProperties = new ParagraphProperties()
                                    {
                                        Justification = new Justification()
                                        {
                                            Val = JustificationValues.Center
                                        }
                                    }
                                });
                                descriptionHeaderCell.Append(new TableCellProperties()
                                {
                                    TableCellVerticalAlignment = new TableCellVerticalAlignment()
                                    {
                                        Val = TableVerticalAlignmentValues.Center
                                    },
                                    TableCellWidth = new TableCellWidth()
                                    {
                                        Width = "9600"
                                    }
                                });
                                headerTableRow.Append(descriptionHeaderCell);
                                table.Append(headerTableRow);
                                foreach (ReceptionMedicine recMed in reception.ReceptionsMedicines)
                                {
                                    TableRow medicineTableRow = new TableRow();
                                    TableCell medicineNameTableCell = new TableCell(new Paragraph(new Run(new Text(recMed.Medicine.Name))));
                                    medicineTableRow.Append(medicineNameTableCell);
                                    TableCell medicineDescriptionTableCell = new TableCell(new Paragraph(new Run(new Text(recMed.Medicine.Description))));
                                    medicineTableRow.Append(medicineDescriptionTableCell);
                                    table.Append(medicineTableRow);
                                }
                                body.Append(table);
                            }
                        }
                        fileStream.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка создания документа " + exc.Message);
            }
        }
    }
}
