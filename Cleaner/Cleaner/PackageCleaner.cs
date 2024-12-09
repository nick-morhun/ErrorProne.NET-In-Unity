namespace Cleaner
{
    public static class PackageCleaner
    {
        public static void PreparePackages(string basePath)
        {
            foreach (var path in Directory.GetDirectories(basePath))
            {
                Prepare(path);
            }
        }

        private static void Prepare(string packagePath)
        {
            Console.WriteLine($"* Cleaning {packagePath}...");
            // delete all files recursively that don't have .dll in names
            var files = Directory.GetFiles(packagePath, "*.*", SearchOption.AllDirectories);
            var subDirs = Directory.GetDirectories(packagePath, "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                if (file.EndsWith(".dll"))
                {
                    OverrideFile(file);
                    continue;
                }

                if (file.EndsWith(".dll.meta"))
                    continue;

                if (subDirs.All(path => path + ".meta" != file))
                {
                    Console.WriteLine($"Deleting {file}");
                    File.Delete(file);
                }
            }

            Console.WriteLine("Deleting empty directories...");
            // delete recursively all directories that are empty
            CleanDirectory(Directory.GetDirectories(packagePath));
        }

        private static void OverrideFile(string file)
        {
            File.WriteAllText(file, "DUMMY FILE");
        }

        private static void CleanDirectory(string[] localDirs)
        {
            foreach (var localDir in localDirs)
            {
                CleanDirectory(Directory.GetDirectories(localDir));

                var directories = Directory.GetDirectories(localDir);

                if (Directory.GetFiles(localDir).Length == 0 && directories.Length == 0)
                {
                    Console.WriteLine($"Deleting {localDir}");
                    Directory.Delete(localDir);

                    if (File.Exists(localDir + ".meta"))
                        File.Delete(localDir + ".meta");
                }
            }
        }
    }
}