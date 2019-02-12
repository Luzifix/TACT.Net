﻿using System.Threading.Tasks;

namespace TACT.Net.FileLookup
{
    public interface IFileLookup
    {
        /// <summary>
        /// Opens the FileLookup and loads its contents
        /// </summary>
        void Open(bool fillIdGaps);
        /// <summary>
        /// Saves the FileLookup to it's backing storage
        /// </summary>
        Task Sync();
        /// <summary>
        /// Syncs and Closes the FileLookup
        /// </summary>
        void Close();

        /// <summary>
        /// Returns the fileid associated to the specified filename
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        uint GetOrCreateFileId(string filename);
    }
}
