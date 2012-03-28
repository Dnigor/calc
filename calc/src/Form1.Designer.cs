namespace calc
{
    partial class Form1
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

//        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            //this.SuspendLayout();

            //textbox 
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox.Location = new System.Drawing.Point(50, 25);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(300, 30);
            this.textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //------------------------------------------------
         
            
            //numbuttons
            this.tlpnum.Location = new System.Drawing.Point(50, 70); 
            this.tlpnum.Size = new System.Drawing.Size(100, 150);
            this.tlpnum.AutoSize = true;


            int k=1;
            for (int i = 0; i < 3 ; i++)
            for (int j = 0; j < 3 ; j++)
            {
                this.numbuttons[k] = new System.Windows.Forms.Button();
                this.numbuttons[k].Width = 45;
                this.numbuttons[k].Height = 45;
                this.numbuttons[k].Text = k.ToString();
                this.numbuttons[k].Tag = k;
                this.numbuttons[k].Name = "button" + k.ToString();
                this.numbuttons[k].Click += new System.EventHandler(this.button_Click);

                this.tlpnum.Controls.Add(this.numbuttons[k], j, i);
                this.numbuttons[k].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
                                
                this.numbuttons[k].Dock = System.Windows.Forms.DockStyle.Fill;
                k++;
            }
                this.numbuttons[0] = new System.Windows.Forms.Button();
                this.numbuttons[0].Location = new System.Drawing.Point(104, 226); 
                this.numbuttons[0].Width = 45;
                this.numbuttons[0].Height = 45;
                this.numbuttons[0].Text = "0";
                this.numbuttons[0].Tag = 0;
                this.numbuttons[0].Name = "button0";
                this.numbuttons[0].Click += new System.EventHandler(this.button_Click);
                
            
            //opbuttons
                this.tlpop.Location = new System.Drawing.Point(250, 70);
                this.tlpop.Size = new System.Drawing.Size(50, 200);
                this.tlpnum.AutoSize = true;
                              
                for (int i = 0; i < 4 ; i++)
                {
                    this.opbuttons[i] = new System.Windows.Forms.Button();
                    this.opbuttons[i].Width = 45;
                    this.opbuttons[i].Height = 45;
                    this.opbuttons[i].Click += new System.EventHandler(this.button_Click);
                    this.tlpop.Controls.Add(this.opbuttons[i], 0, i);       
                }

                this.opbuttons[0].Text = "+"; this.opbuttons[0].Name = "buttonplus";
                this.opbuttons[1].Text = "-"; this.opbuttons[1].Name = "buttonminus";
                this.opbuttons[2].Text = "*"; this.opbuttons[2].Name = "buttonmul";
                this.opbuttons[3].Text = "/"; this.opbuttons[3].Name = "buttondiv";


                this.buttonc = new System.Windows.Forms.Button();
                this.buttonc.Location = new System.Drawing.Point(303, 73);
                this.buttonc.Width = 45;
                this.buttonc.Height = 45;
                this.buttonc.Text = "C";
                this.buttonc.Name = "buttonc";
                this.buttonc.Click += new System.EventHandler(this.button_Click);

                this.buttonequals = new System.Windows.Forms.Button();
                this.buttonequals.Location = new System.Drawing.Point(303, 226);
                this.buttonequals.Width = 45;
                this.buttonequals.Height = 45;
                this.buttonequals.Text = "=";
                this.buttonequals.Name = "buttonequals";
                this.buttonequals.Click += new System.EventHandler(this.button_Click);



            //Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            //add controls
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.tlpnum);
            this.Controls.Add(this.numbuttons[0]);
            this.Controls.Add(this.tlpop);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.buttonequals); 
            //----------------------------------
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();
            //--------------------------------------------


        }

    //    #endregion
        System.Windows.Forms.TextBox textbox = new System.Windows.Forms.TextBox();
        System.Windows.Forms.Button[] numbuttons = new System.Windows.Forms.Button[10];
        System.Windows.Forms.Button[] opbuttons = new System.Windows.Forms.Button[4];
        System.Windows.Forms.Button buttonc = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonequals = new System.Windows.Forms.Button();
        System.Windows.Forms.TableLayoutPanel tlpnum = new System.Windows.Forms.TableLayoutPanel();
        System.Windows.Forms.TableLayoutPanel tlpop = new System.Windows.Forms.TableLayoutPanel();
        ccontroller cr = new ccontroller();

    }
}


