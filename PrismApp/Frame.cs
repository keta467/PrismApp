using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing;
using System.IO;

namespace PrismApp
{
    public class Frame
    {
        public string ImageFolderPath
        {
            get { return ConfigurationManager.AppSettings["ImageFolderPath"]; }
        }

        public string UserImagePath
        {
            get { return ConfigurationManager.AppSettings["UserImagePath"]; }
        }

        public virtual void Kumitate(MyPrismClass myPrismClass, string[] strs)
        {
        }
    }
    public class HanaFrame : Frame
    {
        public string 花フレーム_ユニット
        {
            get { return "Image \"イメージ\" {0 0 1920 1080  CC  Path \"" + ImageFolderPath + "\" Name \"花フレーム.png\" 0 }"; }
        }
        public string ご出産おめでとうございます_ユニット
        {
            get { return "StringBox {353 323 1215 112  H CL C 32 Style \"LSN太角ゴシック体\" Size 86 100 Color { 228 0 127 255   AntiAlias 2 }Effect {Edge {4 Color { 255 255 255 255  }}GaussDrop {1 SE  ShadeRate 10 Color { 0 0 0 128  }}}Proportional \"ご出産おめでとうございます!\" } "; }
        }

        public string メッセージ本文＿ユニット(string message)
        {
            return "StringBox {382 468 1195 286  H HL CL 32 Style \"LSN太角ゴシック体\" Size 54 100 Color { 228 0 127 255   AntiAlias 2 }Proportional \"" + message + "\" }";
        }

        //"String {650 822 872  H TL Style \"LSN太角ゴシック体\"Size 56 100 Color { 228 0 127 255   AntiAlias 2 } Proportional　\"" + message2 + "\"}";
        public string 名前＿ユニット(string message)
        {
            return "StringBox {1234 726 531 164  H HL CL 32 Style \"LSN太角ゴシック体\" Size 54 100 Color { 228 0 127 255   AntiAlias 2 }Proportional \"" + message + "\" }";
        }

        public override void Kumitate(MyPrismClass myPrismClass, string[] strs)
        {
            myPrismClass.AddUnit(花フレーム_ユニット);
            myPrismClass.AddUnit(ご出産おめでとうございます_ユニット);
            myPrismClass.AddUnit(メッセージ本文＿ユニット(strs[0]));
            myPrismClass.AddUnit(名前＿ユニット(strs[1]));
        }
    }

    public class RibonFrame : Frame
    {
        public string リボンフレーム_ユニット
        {
            get { return "Image \"イメージ\" {0 0 1920 1080  CC  Path \"" + ImageFolderPath + "\" Name \"リボンフレーム.png\" 0 }"; }
        }
        public string メッセージ本文＿ユニット(string message)
        {
            return "StringBox {374 285 1165 548  H HLl CL 32 Style \"LSN太角ゴシック体\" Size 78 100 Color { 229 0 79 255   AntiAlias 2 }Proportional \"" + message + "\" }";
        }

        //"String {650 822 872  H TL Style \"LSN太角ゴシック体\"Size 56 100 Color { 228 0 127 255   AntiAlias 2 } Proportional　\"" + message2 + "\"}";
        //1304 786 473 152  H HL CL 32 
        public string 名前＿ユニット(string message)
        {
            return "StringBox {1300 780 473 152  H HL CL 32 Style \"LSN太角ゴシック体\" Size 58 100 Color { 229 0 79 255   AntiAlias 2 }Proportional \"" + message + "\" }";
        }

        public override void Kumitate(MyPrismClass myPrismClass, string[] strs)
        {
            myPrismClass.AddUnit(リボンフレーム_ユニット);
            myPrismClass.AddUnit(メッセージ本文＿ユニット(strs[0]));
            myPrismClass.AddUnit(名前＿ユニット(strs[1]));


        }
    }

    public class UmeFrame : Frame
    {

        public string 梅フレーム_ユニット
        {
            get { return "Image \"イメージ\" {0 0 1920 1080  CC  Path \"" + ImageFolderPath + "\" Name \"梅フレーム.png\" 0 }"; }
        }
        public string メッセージ本文＿ユニット(string message)
        {
            return "StringBox {213 213 1495 658  H CL CL 44 Style \"LSN太角ゴシック体\" Size 74 100  Color { 0 0 0 255   AntiAlias 2 } Space -20 Proportional \"" + message + "\" }";
        }

        //"String {650 822 872  H TL Style \"LSN太角ゴシック体\"Size 56 100 Color { 228 0 127 255   AntiAlias 2 } Proportional　\"" + message2 + "\"}";
        //1304 786 473 152  H HL CL 32 
        public string 名前＿ユニット(string message)
        {
            return "StringBox {1320 790 473 152  H HL CL 32 Style \"LSN太角ゴシック体\" Size 58 100 Color { 0 0 0 255   AntiAlias 2 }Proportional \"" + message + "\" }";
        }

        public override void Kumitate(MyPrismClass myPrismClass, string[] strs)
        {
            myPrismClass.AddUnit(梅フレーム_ユニット);
            myPrismClass.AddUnit(メッセージ本文＿ユニット(strs[0]));
            myPrismClass.AddUnit(名前＿ユニット(strs[1]));


        }
    }
    public class TorukoFrame : Frame
    {

        public string トルコフレーム_ユニット
        {
            get { return "Image \"イメージ\" {0 0 1920 1080  CC  Path \"" + ImageFolderPath + "\" Name \"トルコ桔梗フレーム.png\" 0 }"; }
        }
        public string お悔やみ申し上げます_ユニット
        {
            get { return "StringBox {267 160 998 112  H HL H 30 Style \"LSN太明朝体\" Size 96 100 Color { 255 255 255 255 AntiAlias 2 }Space 60 Proportional \"心よりお悔やみ\\n申し上げます\" } "; }
        }
        public string メッセージ本文＿ユニット(string message)
        {
            return "StringBox {284 525 985 410  H HLl HL 36 Style \"LSN太明朝体\" Size 58 100  Color { 0 0 0 255   AntiAlias 2 } Proportional \"" + message + "\" }";
        }

        //"String {650 822 872  H TL Style \"LSN太角ゴシック体\"Size 56 100 Color { 228 0 127 255   AntiAlias 2 } Proportional　\"" + message2 + "\"}";
        //1304 786 473 152  H HL CL 32 
        public string 名前＿ユニット(string message)
        {
            return "StringBox {1110 880 473 152  H HL CL 32 Style \"LSN太明朝体\" Size 58 100 Color { 0 0 0 255   AntiAlias 2 }Proportional \"" + message + "\" }";
        }

        public override void Kumitate(MyPrismClass myPrismClass, string[] strs)
        {
            myPrismClass.AddUnit(トルコフレーム_ユニット);
            myPrismClass.AddUnit(お悔やみ申し上げます_ユニット);
            myPrismClass.AddUnit(メッセージ本文＿ユニット(strs[0]));
            myPrismClass.AddUnit(名前＿ユニット(strs[1]));


        }
    }

    public class KOFrame : Frame
    {
        private void saveimage(string base64data)
        {
            //var str = value.Replace("data:image/jpeg;base64,", "");
            //画像を保存
            byte[] bytes = Convert.FromBase64String(base64data);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
                image.Save(UserImagePath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        public string ユーザー画像_ユニット
        {
            get { return "Image \"イメージ\" {0 404 900 640  CC  Path \"" + ImageFolderPath + "\" Name \"import.png\" 0 Resize byRect}"; }
        }
        public string KOフレーム_ユニット
        {
            get { return "Image \"イメージ\" {0 0 1920 1080  CC  Path \"" + ImageFolderPath + "\" Name \"KOフレーム.png\" 0 }"; }
        }
        public string メッセージ本文＿ユニット(string message)
        {
            return "StringBox {949 322 902 412  H HLl CL 32 Style \"LSN太明朝体\" Size 63 100  Color { 0 0 0 255   AntiAlias 2 } Proportional \"" + message + "\" }";
        }

        public string 名前＿ユニット(string message)
        {
            return "StringBox {1249 766 452 168  H HLl CL 32 Style \"LSN太明朝体\" Size 63 100 Color { 0 0 0 255   AntiAlias 2 }Proportional \"" + message + "\" }";
        }

        public override void Kumitate(MyPrismClass myPrismClass, string[] strs)
        {
            saveimage(strs[2]);


            myPrismClass.AddUnit(ユーザー画像_ユニット);
            myPrismClass.AddUnit(KOフレーム_ユニット);
            myPrismClass.AddUnit(メッセージ本文＿ユニット(strs[0]));
            myPrismClass.AddUnit(名前＿ユニット(strs[1]));
        }
    }
    public class HBFrame : Frame
    {
        private void saveimage(string base64data)
        {
            //var str = value.Replace("data:image/jpeg;base64,", "");
            //画像を保存
            byte[] bytes = Convert.FromBase64String(base64data);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
                image.Save(UserImagePath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        public string ユーザー画像_ユニット
        {
            get { return "Image \"イメージ\" {1116 216 604 413  CC  Path \"" + ImageFolderPath + "\" Name \"import.png\" 0 Resize byRect}"; }
        }
        public string HBフレーム_ユニット
        {
            get { return "Image \"イメージ\" {0 0 1920 1080  CC  Path \"" + ImageFolderPath + "\" Name \"HBフレーム.png\" 0 }"; }
        }
        public string メッセージ本文＿ユニット(string message)
        {
            return "StringBox {721 636 966 216  H HLl CL 32 Style \"LSN太明朝体\" Size 63 100  Color { 0 0 0 255   AntiAlias 2 } Proportional \"" + message + "\" }";
        }

        public string 名前＿ユニット(string message)
        {
            return "StringBox {1235 842 430 90  H HLl CL 32 Style \"LSN太明朝体\" Size 63 100 Color { 0 0 0 255   AntiAlias 2 }Proportional \"" + message + "\" }";
        }

        public override void Kumitate(MyPrismClass myPrismClass, string[] strs)
        {
            saveimage(strs[2]);


            myPrismClass.AddUnit(ユーザー画像_ユニット);
            myPrismClass.AddUnit(HBフレーム_ユニット);
            myPrismClass.AddUnit(メッセージ本文＿ユニット(strs[0]));
            myPrismClass.AddUnit(名前＿ユニット(strs[1]));
        }
    }
}