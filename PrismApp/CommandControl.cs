using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp
{
    class CommandControl
    {
        /// <summary>
        /// コマンド送信メソッド
        /// </summary>
        /// <param name="command">コマンドプロンプトで実行するコマンド</param>
        /// <returns>出力結果</returns>
        public string SendCommand(string command)
        {
            Process process = new Process();
            //コマンド名
            process.StartInfo.FileName = "cmd.exe";

            process.StartInfo.Arguments = @"/c " + command;

            //DOSプロンプトの黒い画面を非表示
            process.StartInfo.CreateNoWindow = true;

            //プロセスを新しいウィンドウで起動するか否か
            process.StartInfo.UseShellExecute = false;

            //標準出力をリダイレクトで取得
            process.StartInfo.RedirectStandardOutput = true;
            

            process.Start();

            //出力結果を文字列として受け取る
            string results = process.StandardOutput.ReadToEnd();

            process.WaitForExit();
            process.Close();

            return results;
        }
    }
}
