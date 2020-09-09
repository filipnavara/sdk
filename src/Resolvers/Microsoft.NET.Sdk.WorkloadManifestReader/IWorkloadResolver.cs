﻿using System.Collections.Generic;

namespace Microsoft.NET.Sdk.WorkloadManifestReader
{
    public interface IWorkloadResolver
    {
        IEnumerable<WorkloadResolver.PackInfo> GetInstalledWorkloadPacksOfKind(WorkloadPackKind kind);
        IEnumerable<string> GetPacksInWorkload(string workloadId);
        IList<WorkloadResolver.WorkloadInfo> GetWorkloadSuggestionForMissingPacks(IList<string> packId);
        string? TryGetPackVersion(string packId);
    }
}