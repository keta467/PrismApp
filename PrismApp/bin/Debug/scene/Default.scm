# PRISM4 Default Schema --- Lambda Systems Inc.
Title "Default"
ScenePath ""
CommonScenePath ""
ImagePath "D:\\Files\\private\\scene\\images"
DataPath  ""
TexturePath	"D:\\Lambda\\Bin.V2\\TEXTURE"
LogoPath "D:\\Lambda\\Bin.V2\\Logo"
AudioPath "D:\\Lambda\\Bin.V2\\Audio"
ThumbNailPath ""
OADevice	"GRID-EX32HD"
SceneIO		"Lambda.SioLocal.SceneIO"
UseSceneFontCache
UseDevice Lambda.PcSound.Player { At Break Stop() }

Source "Default" {
  Csv { , Comment "#" }
  SysVar {}
  Struct {
	Column "0" { S 80 }
	Column "1" { S 80 }
	Column "2" { S 80 }
	Column "3" { S 80 }
	Column "4" { S 80 }
	Column "5" { S 80 }
	Column "6" { S 80 }
	Column "7" { S 80 }
  }
}
DataTable "Default" { "Default" }
