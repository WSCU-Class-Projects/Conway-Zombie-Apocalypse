namespace WindowsFormsApplication2
{
    partial class universe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.world = new System.Windows.Forms.PictureBox();
            this.jump = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.play = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.HScrollBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pop = new System.Windows.Forms.Label();
            this.gen = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Zoom = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.intensity = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.world)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // world
            // 
            this.world.BackColor = System.Drawing.Color.Transparent;
            this.world.Location = new System.Drawing.Point(56, 64);
            this.world.Name = "world";
            this.world.Size = new System.Drawing.Size(640, 480);
            this.world.TabIndex = 0;
            this.world.TabStop = false;
            this.world.Click += new System.EventHandler(this.world_Click);
            this.world.Paint += new System.Windows.Forms.PaintEventHandler(this.world_Paint);
            this.world.MouseClick += new System.Windows.Forms.MouseEventHandler(this.world_MouseClick);
            this.world.MouseDown += new System.Windows.Forms.MouseEventHandler(this.world_MouseDown);
            this.world.MouseMove += new System.Windows.Forms.MouseEventHandler(this.world_MouseMove);
            this.world.MouseUp += new System.Windows.Forms.MouseEventHandler(this.world_MouseUp);
            // 
            // jump
            // 
            this.jump.Location = new System.Drawing.Point(724, 476);
            this.jump.Name = "jump";
            this.jump.Size = new System.Drawing.Size(75, 68);
            this.jump.TabIndex = 1;
            this.jump.Text = "Jump Forward1 Gen";
            this.jump.UseVisualStyleBackColor = true;
            this.jump.MouseClick += new System.Windows.Forms.MouseEventHandler(this.jump_MouseClick);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(731, 204);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 32);
            this.reset.TabIndex = 2;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reset_MouseClick);
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(731, 84);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 36);
            this.play.TabIndex = 3;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.MouseClick += new System.Windows.Forms.MouseEventHandler(this.play_MouseClick);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(731, 145);
            this.speed.Maximum = 1000;
            this.speed.Minimum = 50;
            this.speed.Name = "speed";
            this.speed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.speed.Size = new System.Drawing.Size(80, 17);
            this.speed.TabIndex = 4;
            this.speed.Value = 50;
            this.speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speed_Scroll);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(845, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(724, 269);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(100, 20);
            this.size.TabIndex = 6;
            this.size.TextChanged += new System.EventHandler(this.size_TextChanged);
            this.size.Enter += new System.EventHandler(this.size_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Set Size of the Universe";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(711, 308);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Click to NOT wrap";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pop
            // 
            this.pop.AutoSize = true;
            this.pop.Location = new System.Drawing.Point(62, 589);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(75, 13);
            this.pop.TabIndex = 11;
            this.pop.Text = "Population =   ";
            this.pop.Click += new System.EventHandler(this.pop_Click);
            // 
            // gen
            // 
            this.gen.AutoSize = true;
            this.gen.Location = new System.Drawing.Point(208, 589);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(74, 13);
            this.gen.TabIndex = 12;
            this.gen.Text = "Generation =  ";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(472, 584);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Zoom
            // 
            this.Zoom.Location = new System.Drawing.Point(715, 389);
            this.Zoom.Maximum = 20;
            this.Zoom.Minimum = 1;
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(104, 45);
            this.Zoom.TabIndex = 14;
            this.Zoom.Value = 1;
            this.Zoom.Scroll += new System.EventHandler(this.Zoom_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Zoom Bar";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "UniverseSize = ";
            this.label3.UseMnemonic = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // intensity
            // 
            this.intensity.AutoSize = true;
            this.intensity.Location = new System.Drawing.Point(678, 561);
            this.intensity.Name = "intensity";
            this.intensity.Size = new System.Drawing.Size(71, 13);
            this.intensity.TabIndex = 24;
            this.intensity.Text = "Color Intensty";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(629, 584);
            this.trackBar1.Maximum = 700;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(195, 45);
            this.trackBar1.TabIndex = 25;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Number";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // universe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 662);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.intensity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Zoom);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.pop);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.play);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.jump);
            this.Controls.Add(this.world);
            this.Name = "universe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.universe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.world)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox world;
        private System.Windows.Forms.Button jump;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.HScrollBar speed;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label pop;
        private System.Windows.Forms.Label gen;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TrackBar Zoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label intensity;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
    }
}

