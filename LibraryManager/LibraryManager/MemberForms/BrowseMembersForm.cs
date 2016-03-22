using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryManager.Entities;
using LibraryManager.Repositories;
using System.Configuration;
using System.Text.RegularExpressions;

namespace LibraryManager
{
    public partial class BrowseMembersForm : Form
    {
        private readonly IMemberRepository _memberRepository;
        public int _memberId;

        public BrowseMembersForm()
        {
            _memberRepository = new SqlMemberRepository(ConfigurationManager.ConnectionStrings["dbLibrary"].ConnectionString);            
           
            InitializeComponent();
            IEnumerable<MemberIdInfo> memberList = _memberRepository.SelectMembersIdInfo(cmbFilterMembers.Text, txtSearchMembers.Text);
            dataGridViewMembers.ClearSelection();
            dataGridViewMembers.DataSource = memberList;

        }

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtSearchMembers.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Wrong data in search");
            }
            else
            {
                IEnumerable<MemberIdInfo> memberList = _memberRepository.SelectMembersIdInfo(cmbFilterMembers.Text, txtSearchMembers.Text);
                dataGridViewMembers.ClearSelection();
                dataGridViewMembers.DataSource = memberList;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int StartSearch()
        {
            return _memberId;
        }

        private void btnGetPassport_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridViewMembers.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                string passport = dataGridViewMembers.SelectedRows[0].Cells[0].Value.ToString();
                
                MemberId member = _memberRepository.GetMemberIdByPassport(passport);
                this._memberId = member.Id;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Select 1 row first");
            }
        }
    }
}
