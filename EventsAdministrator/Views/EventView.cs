using EventsAdministrator.Views;
using EventsAdministrator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsAdministrator
{
    public partial class EventView : Form, IEventView
    {
        public EventView()
        {
            InitializeComponent();
            _associateAndRaiseViewEvents();
        }

        public void _associateAndRaiseViewEvents()
        {
            button_add.Click += (sender, e) =>
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
            };
            button_delete.Click += (sender, e) =>
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
            };
            button_save.Click += (sender, e) =>
            {
                SerializeEvent?.Invoke(this, EventArgs.Empty);
            };
            button_upload.Click += (sender, e) =>
            {
                DeserializeEvent?.Invoke(this, EventArgs.Empty);
            };
            button_sort.Click += (sender, e) =>
            {
                SortEvent?.Invoke(this, EventArgs.Empty);
            };
            button_filter.Click += (sender, e) =>
            {
                FilterEvent?.Invoke(this, EventArgs.Empty);
            };
        }
      

        public string Title { get => textBox_title.Text; set => textBox_title.Text = value; }
        public string Info { get => richTextBox_info.Text; set => richTextBox_info.Text = value; }
        public DateTime Date { get => dateTimePicker.Value; set => dateTimePicker.Value = value; }
        public string Type { get => comboBox_type.Text; set => comboBox_type.Text = value; }
        public string Priority
        {
            get
            {
                if (radioButton_prioHigh.Checked) { return radioButton_prioHigh.Text; }
                else if (radioButton_prioMedium.Checked) { return radioButton_prioMedium.Text; }
                else if (radioButton_prioLow.Checked) { return radioButton_prioLow.Text; }
                else return "";
            }
            set
            {
                if (value == radioButton_prioHigh.Text) { radioButton_prioHigh.Checked = true; }
                else if (value == radioButton_prioMedium.Text) { radioButton_prioMedium.Checked = true; }
                else { radioButton_prioLow.Checked = true; }
            }
        }
        public string Sort
        {
            get
            {
                if (radioButton_sortDate.Checked) { return radioButton_sortDate.Text; }
                else if (radioButton_sortType.Checked) { return radioButton_sortType.Text; }
                else if (radioButton_sortPrio.Checked) { return radioButton_sortPrio.Text;}
                else return "";
            }
        }
        public string Filter
        {
            get
            {
                if (radioButton_filterDate.Checked) { return dateTimePicker_filter.Value.ToShortDateString(); }
                else if (radioButton_filterType.Checked) { return comboBox_filterType.Text; }
                else if (radioButton_filterPrio.Checked) { return comboBox_filterPriority.Text; }
                else return "";
            }
        }

        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SerializeEvent;
        public event EventHandler DeserializeEvent;
        public event EventHandler SortEvent;
        public event EventHandler FilterEvent;

        public bool SetErrorTitle()
        {
            if (textBox_title.Text == "")
            {
                errorProvider1.SetError(textBox_title, "puste");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox_title, "");
                return true;
            }
        }
        public bool SetErrorInfo()
        {
            if (richTextBox_info.Text == "")
            {
                errorProvider1.SetError(richTextBox_info, "puste");
                return false;
            }
            else
            {
                errorProvider1.SetError(richTextBox_info, "");
                return true;
            }
        }
        public bool SetErrorType()
        {
            if (comboBox_type.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox_type, "nie wybrano");
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBox_type, "");
                return true;
            }
        }
        public bool SetErrorPriority()
        {
            if (!radioButton_prioHigh.Checked && !radioButton_prioMedium.Checked && !radioButton_prioLow.Checked)
            {
                errorProvider1.SetError(radioButton_prioHigh, "nie wybrano");
                return false;
            } 
            else
            {
                errorProvider1.SetError(radioButton_prioHigh, "");
                return true;
            }
        }
        public bool SetErrorSort()
        {
            if (!radioButton_sortDate.Checked && !radioButton_sortPrio.Checked && !radioButton_sortType.Checked)
            {
                errorProvider1.SetError(button_sort, "nie wybrano");
                return false;
            }
            else
            {
                errorProvider1.SetError(radioButton_sortDate, "");
                return true;
            }
        }
        public bool SetErrorFilter()
        {
            if (!radioButton_filterDate.Checked && !radioButton_filterPrio.Checked && !radioButton_filterType.Checked)
            {
                errorProvider1.SetError(radioButton_filterDate, "nie wybrano");
                return false;
            }
            else if (radioButton_filterType.Checked && comboBox_filterType.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox_filterType, "nie wybrano");
                return false;
            }
            else if (radioButton_filterPrio.Checked && comboBox_filterPriority.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox_filterPriority, "nie wybrano");
                return false;
            }
            else
            {
                errorProvider1.SetError(radioButton_filterDate, "");
                errorProvider1.SetError(comboBox_filterType, "");
                errorProvider1.SetError(comboBox_filterPriority, "");
                return true;
            }
        }

        public void DataGridUpdate(Event ev)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[dataGridView.Rows.Add(ev.Title, ev.Date.ToShortDateString(), ev.Type, ev.Priority, ev.Info)];
            if (ev.Type == "Praca")
            {
                row.DefaultCellStyle.BackColor = Color.LimeGreen;
            }
            else if (ev.Type == "Rodzina")
            {
                row.DefaultCellStyle.BackColor = Color.Beige;
            }
            else if (ev.Type == "Przyjaciele")
            {
                row.DefaultCellStyle.BackColor = Color.Blue;
            }
            else if (ev.Type == "Rozrywka")
            {
                row.DefaultCellStyle.BackColor = Color.Cyan;
            }
            else if (ev.Type == "Zdrowie")
            {
                row.DefaultCellStyle.BackColor = Color.LightPink;
            }
            else if (ev.Type == "Sport")
            {
                row.DefaultCellStyle.BackColor = Color.LightSeaGreen;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.LightYellow;
            }
            Clear();
        }
        public void DataGridClear()
        {
            dataGridView.Rows.Clear();
        }
        public List<int> DataGridDeleteRows()
        {
            var indexList = new List<int>();
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        indexList.Add(row.Index);
                        dataGridView.Rows.Remove(row);
                    }

                }
            }
            return indexList;
        }
        public void Clear()
        {
            textBox_title.Text = "";
            richTextBox_info.Text = "";
            dateTimePicker.Value = DateTime.Now;
            comboBox_type.SelectedIndex = -1;
            radioButton_prioHigh.Checked = false;
            radioButton_prioMedium.Checked = false;
            radioButton_prioLow.Checked = false;
        }
    }
}
