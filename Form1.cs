namespace ExpenseTracker
{
    public class Form1 : Form
    {
        private List<Expense> _expenses = new List<Expense>();

        private TextBox txtTitle;
        private TextBox txtAmount;
        private ComboBox cmbCategory;
        private Button btnAdd;
        private ListBox lstHistory;
        private Label lblTotal;

        public Form1()
        {
            this.Text = "⚡ Personal Expense Tracker";
            this.Size = new Size(450, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(243, 244, 246);

            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            Label lblTitle = new Label()
            {
                Text = "Expense Title:",
                Location = new Point(30, 20),
                Size = new Size(150, 20),
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            txtTitle = new TextBox()
            {
                Location = new Point(30, 45),
                Size = new Size(370, 25)
            };

            Label lblAmount = new Label()
            {
                Text = "Amount ($):",
                Location = new Point(30, 85),
                Size = new Size(150, 20),
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            txtAmount = new TextBox()
            {
                Location = new Point(30, 110),
                Size = new Size(170, 25)
            };

            Label lblCategory = new Label()
            {
                Text = "Category:",
                Location = new Point(230, 85),
                Size = new Size(150, 20),
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            cmbCategory = new ComboBox()
            {
                Location = new Point(230, 110),
                Size = new Size(170, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cmbCategory.Items.AddRange(new string[]
            {
                "Food",
                "Transport",
                "Bills",
                "Entertainment",
                "Others"
            });

            cmbCategory.SelectedIndex = 0;

            btnAdd = new Button()
            {
                Text = "➕ Add Expense",
                Location = new Point(30, 155),
                Size = new Size(370, 35),
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            btnAdd.Click += OnAddExpenseClick;

            lblTotal = new Label()
            {
                Text = "Total Spent: $0.00",
                Location = new Point(30, 210),
                Size = new Size(370, 40),
                BackColor = Color.FromArgb(239, 68, 68),
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblHistory = new Label()
            {
                Text = "📜 Expense History:",
                Location = new Point(30, 265),
                Size = new Size(180, 20),
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            lstHistory = new ListBox()
            {
                Location = new Point(30, 290),
                Size = new Size(370, 140),
                Font = new Font("Consolas", 10)
            };

            this.Controls.Add(lblTitle);
            this.Controls.Add(txtTitle);
            this.Controls.Add(lblAmount);
            this.Controls.Add(txtAmount);
            this.Controls.Add(lblCategory);
            this.Controls.Add(cmbCategory);
            this.Controls.Add(btnAdd);
            this.Controls.Add(lblTotal);
            this.Controls.Add(lblHistory);
            this.Controls.Add(lstHistory);
        }

        private void OnAddExpenseClick(object? sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string amountText = txtAmount.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString() ?? "Others";

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(amountText))
            {
                MessageBox.Show(
                    "Please fill up all fields!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (double.TryParse(amountText, out double amount))
            {
                Expense exp = new Expense()
                {
                    Title = title,
                    Amount = amount,
                    Category = category
                };

                _expenses.Add(exp);

                UpdateUI();

                txtTitle.Clear();
                txtAmount.Clear();
                cmbCategory.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(
                    "Please enter a valid amount!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void UpdateUI()
        {
            lstHistory.Items.Clear();

            foreach (var exp in _expenses)
            {
                lstHistory.Items.Add(
                    $"[{exp.Category}] {exp.Title,-15} -> ${exp.Amount:F2}"
                );
            }

            double totalSpent = _expenses.Sum(x => x.Amount);

            lblTotal.Text = $"Total Spent: ${totalSpent:F2}";
        }
    }
}
