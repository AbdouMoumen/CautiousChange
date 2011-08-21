using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.PlugInCore;
using DevExpress.CodeRush.StructuralParser;

namespace CautiousChange
{
    public partial class PlugIn1 : StandardPlugIn
    {
        // DXCore-generated code...
        #region InitializePlugIn
        public override void InitializePlugIn()
        {
            base.InitializePlugIn();

            //
            // TODO: Add your initialization code here.
            //
        }
        #endregion
        #region FinalizePlugIn
        public override void FinalizePlugIn()
        {
            //
            // TODO: Add your finalization code here.
            //

            base.FinalizePlugIn();
        }
        #endregion

        private void actCautiousChange_Execute(ExecuteEventArgs ea)
        {
            var activeTextDocument = CodeRush.Documents.ActiveTextDocument;
            if (activeTextDocument == null)
                return;

            var selection = activeTextDocument.ActiveViewSelection;
            selection.ExtendToWholeLines();
            
            var commentedSelection = Environment.NewLine + CodeRush.Language.GetComment("Old code");

            foreach (var line in selection.Lines)
                commentedSelection += CodeRush.Language.GetComment(line);
            commentedSelection += CodeRush.Language.GetComment("--------------");
            
            selection.Text = commentedSelection + selection.Text;

            if(selection.AnchorIsAtEnd)
                selection.SwapPoints();
            selection.Clear();
        }
    }
}