using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77式夜戦模擬計算機
{
    class FileWatcher
    {
        private System.IO.FileSystemWatcher watcher = null;
        VirtualKCMaschine VM = new VirtualKCMaschine();
        JSONAnalysis Ja = new JSONAnalysis();
        Form2 ViewForm;
        public void FileWatchStart(string PathName,Form2 ViewForm)
        {
            if (watcher != null) return;

            this.ViewForm = ViewForm;
            watcher = new System.IO.FileSystemWatcher();
            watcher.Path = PathName;
            watcher.NotifyFilter =
                (System.IO.NotifyFilters.LastAccess
                | System.IO.NotifyFilters.LastWrite
                | System.IO.NotifyFilters.FileName
                | System.IO.NotifyFilters.DirectoryName);
            watcher.Filter = "";

            watcher.Created += new System.IO.FileSystemEventHandler(Watcher_Changed);

            watcher.EnableRaisingEvents = true;
            Console.WriteLine("監視を開始しました。");
        }

        public void FileWatchEnd()
        {
            watcher.EnableRaisingEvents = false;
            watcher.Dispose();
            watcher = null;
            Console.WriteLine("監視を終了しました。");
        }

        private void Watcher_Changed(System.Object source, System.IO.FileSystemEventArgs e)
        {
            var str = Ja.LoadJSON(e.FullPath);
            var Status = Ja.JudgeStatus(e.FullPath);
            VM.OnReceiveJson(Status, str);
            ViewForm.RefreshFromJson(Status, VM);
        }
    } 
}
