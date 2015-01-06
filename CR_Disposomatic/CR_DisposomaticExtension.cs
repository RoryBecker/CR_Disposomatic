using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_Disposomatic
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_Dispos_o_maticExtension : IVsixPluginExtension { }
}