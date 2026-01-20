using System;
using System.Windows.Forms;
using WinFormsApp1.utility;
using HospitalManagementSystem;
using HospitalApp.forms;

namespace WinFormsApp1
{
    internal class AppContext : ApplicationContext
    {
        public AppContext()
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            var login = new login_form();
            login.FormClosed += OnMainFormClosed;
            SetMainForm(login);
        }

        private void ShowDashboardForRole()
        {
            string role = AppSession.RoleName ?? string.Empty;
            Form nextForm;

            if (string.Equals(role, "doctor", StringComparison.OrdinalIgnoreCase))
            {
                nextForm = new DoctorDashboardForm();
            }
            else if (string.Equals(role, "staff", StringComparison.OrdinalIgnoreCase))
            {
                nextForm = new staff_dashboard();
            }
            else if (string.Equals(role, "admin", StringComparison.OrdinalIgnoreCase))
            {
                nextForm = new admin_dash();
            }
            else
            {
                AppSession.Logout();
                ShowLogin();
                return;
            }

            nextForm.FormClosed += OnMainFormClosed;
            SetMainForm(nextForm);
        }

        private void SetMainForm(Form form)
        {
            if (MainForm == null)
            {
                MainForm = form;
                MainForm.Show();
                return;
            }

            var previous = MainForm;
            previous.FormClosed -= OnMainFormClosed;

            MainForm = form;
            MainForm.FormClosed += OnMainFormClosed;

            MainForm.Show();
            previous.Close();
        }

        private void OnMainFormClosed(object? sender, FormClosedEventArgs e)
        {
            // If a login just completed (session established), open the correct dashboard
            if (AppSession.UserID > 0 && !string.IsNullOrEmpty(AppSession.RoleName))
            {
                ShowDashboardForRole();
                return;
            }
            ExitThread();
        }
    }
}