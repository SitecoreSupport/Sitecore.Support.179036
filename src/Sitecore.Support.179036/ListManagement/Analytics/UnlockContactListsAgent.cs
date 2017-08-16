namespace Sitecore.Support.ListManagement.Analytics
{
    using Sitecore.ContentSearch;
    using Sitecore.Abstractions;
    using Sitecore.Analytics.Data.Bulk.Contact;
    using Sitecore.Analytics.Model.Entities;
    using Sitecore.ListManagement.ContentSearch.Model;
    public class UnlockContactListsAgent : Sitecore.ListManagement.Analytics.UnlockContactListsAgent
    {
        public UnlockContactListsAgent(Sitecore.ListManagement.ListManager<ContactList, ContactData> listManager, Sitecore.ListManagement.ContentSearch.BatchIdMapper mapper, Sitecore.Analytics.Data.Bulk.BulkOperationManager<IContactTemplate, KnownContactSet, IContactUpdateResult> operationManager) : base(listManager, mapper, operationManager)
        {
        }

        public UnlockContactListsAgent(Sitecore.ListManagement.ListManager<ContactList, ContactData> listManager, Sitecore.ListManagement.ContentSearch.BatchIdMapper mapper, Sitecore.Analytics.Data.Bulk.BulkOperationManager<IContactTemplate, KnownContactSet, IContactUpdateResult> operationManager, BaseLog logger) : base(listManager, mapper, operationManager, logger)
        {
        }
            
        public override void Execute()
        {
            if (Disabled)
            {
                Disabled = ContentSearchManager.GetAnalyticsIndex().IndexingState != IndexingState.Started;
            }
            base.Execute();
        }
    }
}