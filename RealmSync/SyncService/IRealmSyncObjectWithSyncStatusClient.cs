﻿namespace RealmSync.SyncService
{
    public interface IRealmSyncObjectWithSyncStatusClient : IRealmSyncObjectClient
    {
        int SyncStatus { get; set; }
    }
}