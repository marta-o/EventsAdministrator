using System.Drawing;

namespace EventsAdministrator
{
    partial class EventView
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_title = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_priority = new System.Windows.Forms.Label();
            this.label_events = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.richTextBox_info = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.radioButton_prioHigh = new System.Windows.Forms.RadioButton();
            this.radioButton_prioMedium = new System.Windows.Forms.RadioButton();
            this.radioButton_prioLow = new System.Windows.Forms.RadioButton();
            this.groupBox_event = new System.Windows.Forms.GroupBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.radioButton_sortPrio = new System.Windows.Forms.RadioButton();
            this.radioButton_sortType = new System.Windows.Forms.RadioButton();
            this.radioButton_sortDate = new System.Windows.Forms.RadioButton();
            this.button_sort = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Tytuł = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priorytet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox_filterType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_filter = new System.Windows.Forms.DateTimePicker();
            this.comboBox_filterPriority = new System.Windows.Forms.ComboBox();
            this.button_filter = new System.Windows.Forms.Button();
            this.groupBox_sort = new System.Windows.Forms.GroupBox();
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.radioButton_filterPrio = new System.Windows.Forms.RadioButton();
            this.radioButton_filterType = new System.Windows.Forms.RadioButton();
            this.radioButton_filterDate = new System.Windows.Forms.RadioButton();
            this.groupBox_event.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox_sort.SuspendLayout();
            this.groupBox_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(30, 40);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(47, 23);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Tytuł";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_info.Location = new System.Drawing.Point(30, 80);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(44, 23);
            this.label_info.TabIndex = 1;
            this.label_info.Text = "Opis";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_date.Location = new System.Drawing.Point(30, 160);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(46, 23);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "Data";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_type.Location = new System.Drawing.Point(30, 200);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(36, 23);
            this.label_type.TabIndex = 3;
            this.label_type.Text = "Typ";
            // 
            // label_priority
            // 
            this.label_priority.AutoSize = true;
            this.label_priority.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_priority.Location = new System.Drawing.Point(30, 240);
            this.label_priority.Name = "label_priority";
            this.label_priority.Size = new System.Drawing.Size(75, 23);
            this.label_priority.TabIndex = 4;
            this.label_priority.Text = "Priorytet";
            // 
            // label_events
            // 
            this.label_events.AutoSize = true;
            this.label_events.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_events.Location = new System.Drawing.Point(443, 17);
            this.label_events.Name = "label_events";
            this.label_events.Size = new System.Drawing.Size(115, 28);
            this.label_events.TabIndex = 9;
            this.label_events.Text = "Wydarzenia";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(22, 339);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(160, 40);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Dodaj";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(205, 339);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(160, 40);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "Usuń";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_save.Location = new System.Drawing.Point(114, 560);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(180, 40);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Zapisz";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_upload
            // 
            this.button_upload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_upload.Location = new System.Drawing.Point(114, 628);
            this.button_upload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(180, 40);
            this.button_upload.TabIndex = 8;
            this.button_upload.Text = "Wczytaj";
            this.button_upload.UseVisualStyleBackColor = true;
            // 
            // textBox_title
            // 
            this.textBox_title.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_title.Location = new System.Drawing.Point(115, 40);
            this.textBox_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(250, 30);
            this.textBox_title.TabIndex = 11;
            // 
            // richTextBox_info
            // 
            this.richTextBox_info.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_info.Location = new System.Drawing.Point(115, 80);
            this.richTextBox_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_info.Name = "richTextBox_info";
            this.richTextBox_info.Size = new System.Drawing.Size(250, 70);
            this.richTextBox_info.TabIndex = 12;
            this.richTextBox_info.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Location = new System.Drawing.Point(115, 160);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 30);
            this.dateTimePicker.TabIndex = 14;
            // 
            // radioButton_prioHigh
            // 
            this.radioButton_prioHigh.AutoSize = true;
            this.radioButton_prioHigh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_prioHigh.Location = new System.Drawing.Point(115, 240);
            this.radioButton_prioHigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_prioHigh.Name = "radioButton_prioHigh";
            this.radioButton_prioHigh.Size = new System.Drawing.Size(84, 27);
            this.radioButton_prioHigh.TabIndex = 15;
            this.radioButton_prioHigh.TabStop = true;
            this.radioButton_prioHigh.Text = "Wysoki";
            this.radioButton_prioHigh.UseVisualStyleBackColor = true;
            // 
            // radioButton_prioMedium
            // 
            this.radioButton_prioMedium.AutoSize = true;
            this.radioButton_prioMedium.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_prioMedium.Location = new System.Drawing.Point(115, 270);
            this.radioButton_prioMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_prioMedium.Name = "radioButton_prioMedium";
            this.radioButton_prioMedium.Size = new System.Drawing.Size(79, 27);
            this.radioButton_prioMedium.TabIndex = 16;
            this.radioButton_prioMedium.TabStop = true;
            this.radioButton_prioMedium.Text = "Średni";
            this.radioButton_prioMedium.UseVisualStyleBackColor = true;
            // 
            // radioButton_prioLow
            // 
            this.radioButton_prioLow.AutoSize = true;
            this.radioButton_prioLow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_prioLow.Location = new System.Drawing.Point(115, 300);
            this.radioButton_prioLow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_prioLow.Name = "radioButton_prioLow";
            this.radioButton_prioLow.Size = new System.Drawing.Size(67, 27);
            this.radioButton_prioLow.TabIndex = 17;
            this.radioButton_prioLow.TabStop = true;
            this.radioButton_prioLow.Text = "Niski";
            this.radioButton_prioLow.UseVisualStyleBackColor = true;
            // 
            // groupBox_event
            // 
            this.groupBox_event.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_event.Controls.Add(this.comboBox_type);
            this.groupBox_event.Controls.Add(this.radioButton_prioLow);
            this.groupBox_event.Controls.Add(this.radioButton_prioMedium);
            this.groupBox_event.Controls.Add(this.radioButton_prioHigh);
            this.groupBox_event.Controls.Add(this.dateTimePicker);
            this.groupBox_event.Controls.Add(this.richTextBox_info);
            this.groupBox_event.Controls.Add(this.textBox_title);
            this.groupBox_event.Controls.Add(this.button_delete);
            this.groupBox_event.Controls.Add(this.button_add);
            this.groupBox_event.Controls.Add(this.label_priority);
            this.groupBox_event.Controls.Add(this.label_type);
            this.groupBox_event.Controls.Add(this.label_date);
            this.groupBox_event.Controls.Add(this.label_info);
            this.groupBox_event.Controls.Add(this.label_title);
            this.groupBox_event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_event.Location = new System.Drawing.Point(28, 86);
            this.groupBox_event.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_event.Name = "groupBox_event";
            this.groupBox_event.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_event.Size = new System.Drawing.Size(395, 400);
            this.groupBox_event.TabIndex = 19;
            this.groupBox_event.TabStop = false;
            this.groupBox_event.Text = "Dane wydarzenia";
            // 
            // comboBox_type
            // 
            this.comboBox_type.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Praca",
            "Rodzina",
            "Przyjaciele",
            "Rozrywka",
            "Zdrowie",
            "Sport",
            "Inne"});
            this.comboBox_type.Location = new System.Drawing.Point(115, 200);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(250, 31);
            this.comboBox_type.TabIndex = 18;
            // 
            // radioButton_sortPrio
            // 
            this.radioButton_sortPrio.AutoSize = true;
            this.radioButton_sortPrio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_sortPrio.Location = new System.Drawing.Point(15, 120);
            this.radioButton_sortPrio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_sortPrio.Name = "radioButton_sortPrio";
            this.radioButton_sortPrio.Size = new System.Drawing.Size(135, 27);
            this.radioButton_sortPrio.TabIndex = 23;
            this.radioButton_sortPrio.TabStop = true;
            this.radioButton_sortPrio.Text = "Po priorytecie";
            this.radioButton_sortPrio.UseVisualStyleBackColor = true;
            // 
            // radioButton_sortType
            // 
            this.radioButton_sortType.AutoSize = true;
            this.radioButton_sortType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_sortType.Location = new System.Drawing.Point(15, 80);
            this.radioButton_sortType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_sortType.Name = "radioButton_sortType";
            this.radioButton_sortType.Size = new System.Drawing.Size(92, 27);
            this.radioButton_sortType.TabIndex = 22;
            this.radioButton_sortType.TabStop = true;
            this.radioButton_sortType.Text = "Po typie";
            this.radioButton_sortType.UseVisualStyleBackColor = true;
            // 
            // radioButton_sortDate
            // 
            this.radioButton_sortDate.AutoSize = true;
            this.radioButton_sortDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_sortDate.Location = new System.Drawing.Point(15, 40);
            this.radioButton_sortDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_sortDate.Name = "radioButton_sortDate";
            this.radioButton_sortDate.Size = new System.Drawing.Size(95, 27);
            this.radioButton_sortDate.TabIndex = 21;
            this.radioButton_sortDate.TabStop = true;
            this.radioButton_sortDate.Text = "Po dacie";
            this.radioButton_sortDate.UseVisualStyleBackColor = true;
            // 
            // button_sort
            // 
            this.button_sort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sort.Location = new System.Drawing.Point(160, 70);
            this.button_sort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(132, 40);
            this.button_sort.TabIndex = 24;
            this.button_sort.Text = "Sortuj";
            this.button_sort.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tytuł,
            this.Data,
            this.Typ,
            this.Priorytet,
            this.Opis});
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(450, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(900, 488);
            this.dataGridView.TabIndex = 25;
            // 
            // Tytuł
            // 
            this.Tytuł.HeaderText = "Tytuł";
            this.Tytuł.MinimumWidth = 6;
            this.Tytuł.Name = "Tytuł";
            this.Tytuł.Width = 125;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.Width = 125;
            // 
            // Typ
            // 
            this.Typ.HeaderText = "Typ";
            this.Typ.MinimumWidth = 6;
            this.Typ.Name = "Typ";
            this.Typ.Width = 125;
            // 
            // Priorytet
            // 
            this.Priorytet.HeaderText = "Priorytet";
            this.Priorytet.MinimumWidth = 6;
            this.Priorytet.Name = "Priorytet";
            this.Priorytet.Width = 125;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox_filterType
            // 
            this.comboBox_filterType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_filterType.FormattingEnabled = true;
            this.comboBox_filterType.Items.AddRange(new object[] {
            "Praca",
            "Rodzina",
            "Przyjaciele",
            "Rozrywka",
            "Zdrowie",
            "Sport",
            "Inne"});
            this.comboBox_filterType.Location = new System.Drawing.Point(160, 80);
            this.comboBox_filterType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_filterType.Name = "comboBox_filterType";
            this.comboBox_filterType.Size = new System.Drawing.Size(215, 31);
            this.comboBox_filterType.TabIndex = 33;
            // 
            // dateTimePicker_filter
            // 
            this.dateTimePicker_filter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_filter.Location = new System.Drawing.Point(160, 40);
            this.dateTimePicker_filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_filter.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_filter.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_filter.Name = "dateTimePicker_filter";
            this.dateTimePicker_filter.Size = new System.Drawing.Size(215, 30);
            this.dateTimePicker_filter.TabIndex = 31;
            // 
            // comboBox_filterPriority
            // 
            this.comboBox_filterPriority.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_filterPriority.FormattingEnabled = true;
            this.comboBox_filterPriority.Items.AddRange(new object[] {
            "Wysoki",
            "Średni",
            "Niski"});
            this.comboBox_filterPriority.Location = new System.Drawing.Point(160, 120);
            this.comboBox_filterPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_filterPriority.Name = "comboBox_filterPriority";
            this.comboBox_filterPriority.Size = new System.Drawing.Size(215, 31);
            this.comboBox_filterPriority.TabIndex = 34;
            // 
            // button_filter
            // 
            this.button_filter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_filter.Location = new System.Drawing.Point(400, 70);
            this.button_filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(132, 40);
            this.button_filter.TabIndex = 35;
            this.button_filter.Text = "Filtruj";
            this.button_filter.UseVisualStyleBackColor = true;
            // 
            // groupBox_sort
            // 
            this.groupBox_sort.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_sort.Controls.Add(this.button_sort);
            this.groupBox_sort.Controls.Add(this.radioButton_sortPrio);
            this.groupBox_sort.Controls.Add(this.radioButton_sortType);
            this.groupBox_sort.Controls.Add(this.radioButton_sortDate);
            this.groupBox_sort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_sort.Location = new System.Drawing.Point(450, 560);
            this.groupBox_sort.Name = "groupBox_sort";
            this.groupBox_sort.Size = new System.Drawing.Size(325, 170);
            this.groupBox_sort.TabIndex = 36;
            this.groupBox_sort.TabStop = false;
            this.groupBox_sort.Text = "Sortowanie";
            // 
            // groupBox_filter
            // 
            this.groupBox_filter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_filter.Controls.Add(this.radioButton_filterPrio);
            this.groupBox_filter.Controls.Add(this.radioButton_filterType);
            this.groupBox_filter.Controls.Add(this.radioButton_filterDate);
            this.groupBox_filter.Controls.Add(this.button_filter);
            this.groupBox_filter.Controls.Add(this.comboBox_filterPriority);
            this.groupBox_filter.Controls.Add(this.comboBox_filterType);
            this.groupBox_filter.Controls.Add(this.dateTimePicker_filter);
            this.groupBox_filter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_filter.Location = new System.Drawing.Point(790, 560);
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.Size = new System.Drawing.Size(560, 172);
            this.groupBox_filter.TabIndex = 37;
            this.groupBox_filter.TabStop = false;
            this.groupBox_filter.Text = "Filtrowanie";
            // 
            // radioButton_filterPrio
            // 
            this.radioButton_filterPrio.AutoSize = true;
            this.radioButton_filterPrio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_filterPrio.Location = new System.Drawing.Point(15, 120);
            this.radioButton_filterPrio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_filterPrio.Name = "radioButton_filterPrio";
            this.radioButton_filterPrio.Size = new System.Drawing.Size(135, 27);
            this.radioButton_filterPrio.TabIndex = 38;
            this.radioButton_filterPrio.TabStop = true;
            this.radioButton_filterPrio.Text = "Po priorytecie";
            this.radioButton_filterPrio.UseVisualStyleBackColor = true;
            // 
            // radioButton_filterType
            // 
            this.radioButton_filterType.AutoSize = true;
            this.radioButton_filterType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_filterType.Location = new System.Drawing.Point(15, 80);
            this.radioButton_filterType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_filterType.Name = "radioButton_filterType";
            this.radioButton_filterType.Size = new System.Drawing.Size(92, 27);
            this.radioButton_filterType.TabIndex = 37;
            this.radioButton_filterType.TabStop = true;
            this.radioButton_filterType.Text = "Po typie";
            this.radioButton_filterType.UseVisualStyleBackColor = true;
            // 
            // radioButton_filterDate
            // 
            this.radioButton_filterDate.AutoSize = true;
            this.radioButton_filterDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_filterDate.Location = new System.Drawing.Point(15, 40);
            this.radioButton_filterDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_filterDate.Name = "radioButton_filterDate";
            this.radioButton_filterDate.Size = new System.Drawing.Size(95, 27);
            this.radioButton_filterDate.TabIndex = 36;
            this.radioButton_filterDate.TabStop = true;
            this.radioButton_filterDate.Text = "Po dacie";
            this.radioButton_filterDate.UseVisualStyleBackColor = true;
            // 
            // EventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1384, 756);
            this.Controls.Add(this.groupBox_filter);
            this.Controls.Add(this.groupBox_sort);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox_event);
            this.Controls.Add(this.label_events);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.button_save);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventView";
            this.Text = "Administrator wydarzeń";
            this.groupBox_event.ResumeLayout(false);
            this.groupBox_event.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox_sort.ResumeLayout(false);
            this.groupBox_sort.PerformLayout();
            this.groupBox_filter.ResumeLayout(false);
            this.groupBox_filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_priority;
        private System.Windows.Forms.Label label_events;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.RichTextBox richTextBox_info;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton radioButton_prioHigh;
        private System.Windows.Forms.RadioButton radioButton_prioMedium;
        private System.Windows.Forms.RadioButton radioButton_prioLow;
        private System.Windows.Forms.GroupBox groupBox_event;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.RadioButton radioButton_sortPrio;
        private System.Windows.Forms.RadioButton radioButton_sortType;
        private System.Windows.Forms.RadioButton radioButton_sortDate;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tytuł;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priorytet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.ComboBox comboBox_filterPriority;
        private System.Windows.Forms.ComboBox comboBox_filterType;
        private System.Windows.Forms.DateTimePicker dateTimePicker_filter;
        private System.Windows.Forms.GroupBox groupBox_filter;
        private System.Windows.Forms.GroupBox groupBox_sort;
        private System.Windows.Forms.RadioButton radioButton_filterPrio;
        private System.Windows.Forms.RadioButton radioButton_filterType;
        private System.Windows.Forms.RadioButton radioButton_filterDate;
    }
}

