using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
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

namespace DesktopDoctor
{
    public partial class PatientForm : Form
    {
        Patient patient;

        public PatientForm(MainForm mainForm, Patient patient)
        {
            InitializeComponent();
            MdiParent = mainForm;
            fenameLabel.Text = patient.Fename;
            nameLabel.Text = patient.Name;
            patronymicLabel.Text = patient.Patronymic;
            genderLabel.Text = "Пол: " + (patient.Gender ? "Мужской" : "Женский");
            birthdateLabel.Text = "Дата рождения: " + patient.Birthdate.ToShortDateString();
            snilsLabel.Text = "СНИЛС: " + patient.SNILS;
            policyLabel.Text = "Полис: " + patient.Policy;
            this.patient = patient;
            receptionBindingSource.DataSource = patient.Receptions.OrderByDescending(r => r.Date).ToList();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToPatientsForm();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToEditPatientForm(patient);
        }

        private void StartReceptionButton_Click(object sender, EventArgs e)
        {
            Reception reception = new Reception
            {
                Patient = patient,
                Employee = (MdiParent as MainForm).account.Employee
            };
            (MdiParent as MainForm).GoToReceptionForm(reception);
        }

        private void ReceptionDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            (MdiParent as MainForm).GoToReceptionForm(receptionBindingSource.Current as Reception);
        }

        private void SaveHistoryButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Document|*.docx",
                Title = "Сохранить историю болезней",
                FileName = "История болезней. Пациент " + patient.ToString()
            };
            saveFileDialog.ShowDialog();
          //  try
         //   {
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
                            body.Append(new Paragraph(new Run(new Text("История болезней"))
                            {
                                RunProperties = new RunProperties()
                                {
                                    Bold = new Bold()
                                    {
                                        Val = new OnOffValue(true)
                                    },
                                    Caps = new Caps()
                                    {
                                        Val = new OnOffValue(true)
                                    },
                                    FontSize = new FontSize()
                                    {
                                        Val = "48"
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
                            body.Append(new Paragraph(new OpenXmlElement[] {
                                new Run(new Text("Фамилия: ")
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
                                new Run(new Text(patient.Fename.ToString())
                                {
                                     Space = SpaceProcessingModeValues.Preserve
                                })
                            }));
                            body.Append(new Paragraph(new OpenXmlElement[] {
                                new Run(new Text("Имя: ")
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
                                new Run(new Text(patient.Name.ToString())
                                {
                                     Space = SpaceProcessingModeValues.Preserve
                                })
                            }));
                            body.Append(new Paragraph(new OpenXmlElement[] {
                                new Run(new Text("Отчество: ")
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
                                new Run(new Text(patient.Patronymic.ToString())
                                {
                                     Space = SpaceProcessingModeValues.Preserve
                                })
                            }));
                            body.Append(new Paragraph(new OpenXmlElement[] {
                                new Run(new Text("Дата рождения: ")
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
                                new Run(new Text(patient.Birthdate.ToShortDateString())
                                {
                                     Space = SpaceProcessingModeValues.Preserve
                                })
                            }));
                            body.Append(new Paragraph(new OpenXmlElement[] {
                                new Run(new Text("Пол: ")
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
                                new Run(new Text(patient.Gender ? "Мужской" : "Женский")
                                {
                                     Space = SpaceProcessingModeValues.Preserve
                                })
                            }));
                            body.Append(new Paragraph(new OpenXmlElement[] {
                                new Run(new Text("СНИЛС: ")
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
                                new Run(new Text(patient.SNILS.ToString())
                                {
                                     Space = SpaceProcessingModeValues.Preserve
                                })
                            }));
                            body.Append(new Paragraph(new OpenXmlElement[] {
                                new Run(new Text("Номер полиса: ")
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
                                new Run(new Text(patient.Policy.ToString())
                                {
                                     Space = SpaceProcessingModeValues.Preserve
                                })
                            }));
                            body.Append(new Paragraph(new Run(new Break() { Type = BreakValues.Page })));
                            foreach (Reception reception in patient.Receptions)
                            {
                                body.Append(new Paragraph(new Run(new Text("Прием " + reception.Date.ToShortDateString()))
                                {
                                    RunProperties = new RunProperties()
                                    {
                                        Bold = new Bold()
                                        {
                                            Val = new OnOffValue(true)
                                        },
                                        Caps = new Caps()
                                        {
                                            Val = new OnOffValue(true)
                                        },
                                        FontSize = new FontSize()
                                        {
                                            Val = "36"
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
                                    new Run(new Text("Температура: ")
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
                                    new Run(new Text(reception.Temperature.ToString())
                                    {
                                         Space = SpaceProcessingModeValues.Preserve
                                    })
                                }));
                                body.Append(new Paragraph(new OpenXmlElement[] {
                                    new Run(new Text("Давление: ")
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
                                    new Run(new Text(reception.Pressure.ToString())
                                    {
                                         Space = SpaceProcessingModeValues.Preserve
                                    })
                                }));
                                body.Append(new Paragraph(new OpenXmlElement[] {
                                    new Run(new Text("Диагноз: ")
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
                                    new Run(new Text(reception.Diagnosis.ToString())
                                    {
                                         Space = SpaceProcessingModeValues.Preserve
                                    })
                                }));
                                body.Append(new Paragraph(new Run(new Text("Симптомы:"))
                                {
                                    RunProperties = new RunProperties()
                                    {
                                        Bold = new Bold()
                                        {
                                            Val = new OnOffValue(true)
                                        }
                                    }
                                }));
                                body.Append(new Paragraph(new Run(new Text(reception.Symptoms == null ? "Нет" : reception.Symptoms.ToString().Length == 0 ? "Нет" : reception.Symptoms.ToString()))));
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
                                body.Append(new Paragraph(new Run(new Text(reception.Recommendations == null ? "Нет" : reception.Recommendations.ToString().Length == 0 ? "Нет" : reception.Recommendations.ToString()))));
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
                                body.Append(new Paragraph(new Run(new Text())));
                            }
                        }
                        fileStream.Close();
                    }
                }
           /* }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка создания документа " + exc.Message);
            }*/
        }
    }
}
