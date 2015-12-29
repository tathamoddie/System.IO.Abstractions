﻿using System.Collections.Generic;
using System.Security.AccessControl;
#if DOTNET5_4
using System.IO;
#endif

namespace System.IO.Abstractions
{
#if NET40
    [Serializable]
#endif
    public class DirectoryWrapper : DirectoryBase
    {
        public override DirectoryInfoBase CreateDirectory(string path)
        {
            return Directory.CreateDirectory(path);
        }

        public override DirectoryInfoBase CreateDirectory(string path, DirectorySecurity directorySecurity)
        {
#if NET40
            return Directory.CreateDirectory(path, directorySecurity);
#elif DOTNET5_4
            var info = new DirectoryInfo(path);
            info.Create();
            info.SetAccessControl(directorySecurity);
            return info;
#endif
        }

        public override void Delete(string path)
        {
            Directory.Delete(path);
        }

        public override void Delete(string path, bool recursive)
        {
            Directory.Delete(path, recursive);
        }

        public override bool Exists(string path)
        {
            return Directory.Exists(path);
        }

        public override DirectorySecurity GetAccessControl(string path)
        {
#if NET40
            return Directory.GetAccessControl(path);
#elif DOTNET5_4
            var info = new DirectoryInfo(path);
            return info.GetAccessControl();
#endif
        }

        public override DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
        {
#if NET40
            return Directory.GetAccessControl(path, includeSections);
#elif DOTNET5_4
            var info = new DirectoryInfo(path);
            return info.GetAccessControl(includeSections);
#endif
        }

        public override DateTime GetCreationTime(string path)
        {
            return Directory.GetCreationTime(path);
        }

        public override DateTime GetCreationTimeUtc(string path)
        {
            return Directory.GetCreationTimeUtc(path);
        }

        public override string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        public override string[] GetDirectories(string path)
        {
            return Directory.GetDirectories(path);
        }

        public override string[] GetDirectories(string path, string searchPattern)
        {
            return Directory.GetDirectories(path, searchPattern);
        }

        public override string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetDirectories(path, searchPattern, searchOption);
        }

        public override string GetDirectoryRoot(string path)
        {
            return Directory.GetDirectoryRoot(path);
        }

        public override string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }

        public override string[] GetFiles(string path, string searchPattern)
        {
            return Directory.GetFiles(path, searchPattern);
        }

        public override string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetFiles(path, searchPattern, searchOption);
        }

        public override string[] GetFileSystemEntries(string path)
        {
            return Directory.GetFileSystemEntries(path);
        }

        public override string[] GetFileSystemEntries(string path, string searchPattern)
        {
            return Directory.GetFileSystemEntries(path, searchPattern);
        }

        public override DateTime GetLastAccessTime(string path)
        {
            return Directory.GetLastAccessTime(path);
        }

        public override DateTime GetLastAccessTimeUtc(string path)
        {
            return Directory.GetLastAccessTimeUtc(path);
        }

        public override DateTime GetLastWriteTime(string path)
        {
            return Directory.GetLastWriteTime(path);
        }

        public override DateTime GetLastWriteTimeUtc(string path)
        {
            return Directory.GetLastWriteTimeUtc(path);
        }

#if NET40
        public override string[] GetLogicalDrives()
        {
            return Directory.GetLogicalDrives();
        }
#endif

        public override DirectoryInfoBase GetParent(string path)
        {
            return Directory.GetParent(path);
        }

        public override void Move(string sourceDirName, string destDirName)
        {
            Directory.Move(sourceDirName, destDirName);
        }

        public override void SetAccessControl(string path, DirectorySecurity directorySecurity)
        {
#if NET40
            Directory.SetAccessControl(path, directorySecurity);
#elif DOTNET5_4
            var info = new DirectoryInfo(path);
            info.SetAccessControl(directorySecurity);
#endif
        }

        public override void SetCreationTime(string path, DateTime creationTime)
        {
            Directory.SetCreationTime(path, creationTime);
        }

        public override void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            Directory.SetCreationTimeUtc(path, creationTimeUtc);
        }

        public override void SetCurrentDirectory(string path)
        {
            Directory.SetCurrentDirectory(path);
        }

        public override void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            Directory.SetLastAccessTime(path, lastAccessTime);
        }

        public override void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }

        public override void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            Directory.SetLastAccessTime(path, lastWriteTime);
        }

        public override void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }

        public override IEnumerable<string> EnumerateDirectories(string path)
        {
            return Directory.EnumerateDirectories(path);
        }

        public override IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        {
            return Directory.EnumerateDirectories(path, searchPattern);
        }

        public override IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateDirectories(path, searchPattern, searchOption);
        }

        public override IEnumerable<string> EnumerateFiles(string path)
        {
           return Directory.EnumerateFiles(path);
        }
 
        public override IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            return Directory.EnumerateFiles(path, searchPattern);
        }

        public override IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateFiles(path, searchPattern, searchOption);
        }

        public override IEnumerable<string> EnumerateFileSystemEntries(string path)
        {
            return Directory.EnumerateFileSystemEntries(path);
        }

        public override IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        {
            return Directory.EnumerateFileSystemEntries(path, searchPattern);
        }

        public override IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);
        }
    }
}