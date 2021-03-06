﻿using IssueCreator.Logging;
using System;

namespace IssueCreator.Dialogs
{
    public partial class EpicAssociation : IssueCreator.Dialogs.ManageIssue
    {
        public EpicAssociation() : base()
        {
            InitializeComponent();
        }

        public EpicAssociation(IssueManager issueManager, Settings settings, FileLogger logger, object[] epicList)
            :base(issueManager, settings, logger, epicList)
        {
            InitializeComponent();
        }
        private async void btnAssociateEpic_Click(object sender, EventArgs e)
        {
            await ExecuteIssueOperation(_issueManager.AddIssueToEpicAsync, "Add issue to epic");
        }

        private async void btnDisassociateEpic_Click(object sender, EventArgs e)
        {
            await ExecuteIssueOperation(_issueManager.RemoveIssueFromEpicAsync, "Remove issue to epic");
        }
    }
}
