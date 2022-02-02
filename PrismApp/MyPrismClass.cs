using System;
using PRISMPLAYERLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp
{
    public class MyPrismClass
    {
        public PrismPlayer player;
        private string Defaultscmpath
        {
            get { return $@"D:\\PrismApp\\scene\\Default.scm"; }
        }
        public virtual string Saveimagepath
        {
            get { return $@"D:\\PrismApp\\ok.png"; }
        }

        public virtual string DumpArea
        {
            get { return "0 0 1920 1080"; }
        }

        public MyPrismClass()
        {
            player = new PrismPlayer();
            //初期化
            var result = player.initialize();
            if (result == -1)
            {
                Console.WriteLine("プリズムプレイヤーの初期化に失敗しました。");
            }
            else
            {
                Console.WriteLine("プリズムプレイヤーの初期化に成功しました。");
                //デバイスを取得
                player.execute("GetDevice WinGL HD SendTo 591872 1");

            }
        }

        public int DumpPicture()
        {
            //ダンプピクチャー
            Cheak(player, "DumpPicture \"scene\" \"" + Saveimagepath + "\" Rate 43 Clip " + DumpArea);
            Console.WriteLine("ダンプピクチャ―完了");
            return 0;
        }

        public int AddUnit(String UnitString)
        {
            //ダンプピクチャー
            Cheak(player, "AddUnit " + UnitString);
            Console.WriteLine("アドユニット完了");
            return 0;
        }

        private void Cheak(PrismPlayer player, string quely)
        {
            var result = player.execute(quely);
            if (result == -1)
            {
                Console.WriteLine(quely + "のときエラー");
            }
        }

        public int DumpScene()
        {
            //DumpScene D:\\graph\\ok.png　        //DumpScene Fixed “開票速報” “D:¥¥Sokuho.scn”
            Cheak(player, "DumpScene Fixed \"scene\" \"D:¥¥PrismApp¥¥PrismApp.scn\"");
            Console.WriteLine("DumpScene完了");
            return 0;
        }
        public int Load()
        {
            //ロード
            Cheak(player, "Load \"" + Defaultscmpath + "\"");
            //シーンの選択
            Cheak(player, "SelectScene \"scene\"");
            Console.WriteLine("ロード完了");
            return 0;
        }
    }
}

