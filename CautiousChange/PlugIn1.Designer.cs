namespace CautiousChange
{
    partial class PlugIn1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public PlugIn1()
        {
            /// <summary>
            /// Required for Windows.Forms Class Composition Designer support
            /// </summary>
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlugIn1));
            this.actCautiousChange = new DevExpress.CodeRush.Core.Action(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.actCautiousChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // actCautiousChange
            // 
            this.actCautiousChange.ActionName = "CautiousChange";
            this.actCautiousChange.CommonMenu = DevExpress.CodeRush.Menus.VsCommonBar.None;
            this.actCautiousChange.Description = "Make a backup copy of a peice of code and comment it out, to \"cautiously change i" +
    "t\"";
            this.actCautiousChange.Image = ((System.Drawing.Bitmap)(resources.GetObject("actCautiousChange.Image")));
            this.actCautiousChange.ImageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(0)))));
            this.actCautiousChange.ToolbarItem.ButtonIsPressed = false;
            this.actCautiousChange.ToolbarItem.Caption = null;
            this.actCautiousChange.ToolbarItem.Image = null;
            this.actCautiousChange.Execute += new DevExpress.CodeRush.Core.CommandExecuteEventHandler(this.actCautiousChange_Execute);
            ((System.ComponentModel.ISupportInitialize)(this.actCautiousChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.CodeRush.Core.Action actCautiousChange;
    }
}