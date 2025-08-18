using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlUpdateApp
{
    public class MainForm : Form
    {
        public MainForm()
        {
            // Set up the form controls when initialized
            InitializeControls();
        }

        // Handle the Update Controls button click
        private void BtnUpdateControls_Click(object sender, EventArgs e)
        {
            UpdateControlProperties();
        }

        // Update control appearances based on their tags
        private void UpdateControlProperties()
        {
            // Check if Group1 and Group3 have matching counts
            bool groupsMatch = CheckIfGroupsMatch();

            // Loop through all controls on the form
            foreach (Control control in this.Controls)
            {
                // Process TextBox controls
                if (control is TextBox textBox)
                {
                    // Style Group1 textboxes
                    if ((string)textBox.Tag == "Group1")
                    {
                        textBox.BackColor = groupsMatch ? Color.LightGreen : Color.LightYellow;
                        textBox.ForeColor = Color.DarkBlue;
                    }
                    // Style Group3 textboxes
                    else if ((string)textBox.Tag == "Group3")
                    {
                        // Highlight empty boxes red if groups don't match
                        if (!groupsMatch && string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            textBox.BackColor = Color.Red;
                        }
                        else
                        {
                            textBox.BackColor = Color.White;
                        }
                    }
                }
                // Style Group2 buttons
                else if (control is Button button && (string)button.Tag == "Group2")
                {
                    button.BackColor = Color.Coral;
                }
            }
        }

        // Count controls in Group1 and Group3 to see if they match
        private bool CheckIfGroupsMatch()
        {
            int group1Count = 0;
            int group3Count = 0;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if ((string)textBox.Tag == "Group1") group1Count++;
                    else if ((string)textBox.Tag == "Group3") group3Count++;
                }
            }

            return group1Count == group3Count;
        }

        // Create and configure all the form controls
        private void InitializeControls()
        {
            // Form settings
            this.Text = "Control Update Demo";
            this.ClientSize = new Size(300, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Add Group1 textboxes
            Controls.Add(new TextBox { 
                Tag = "Group1", 
                Name = "group1TextBox1",
                Location = new Point(20, 20), 
                Width = 200 
            });
            
            Controls.Add(new TextBox { 
                Tag = "Group1", 
                Name = "group1TextBox2",
                Location = new Point(20, 60), 
                Width = 200 
            });

            // Add Update button
            var updateButton = new Button
            {
                Tag = "Group2",
                Name = "updateButton",
                Text = "Update Controls",
                Location = new Point(20, 100),
                AutoSize = true
            };
            updateButton.Click += BtnUpdateControls_Click;
            Controls.Add(updateButton);

            // Add Group3 textbox
            Controls.Add(new TextBox { 
                Tag = "Group3", 
                Name = "group3TextBox1",
                Location = new Point(20, 140), 
                Width = 200
            });
        }
    }

    // Program entry point
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}