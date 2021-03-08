namespace Echecs.IHM
{
    partial class FenetreDeJeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreDeJeu));
            this.imgToolMenus = new System.Windows.Forms.ImageList(this.components);
            this.tbr = new System.Windows.Forms.ToolBar();
            this.tbrNew = new System.Windows.Forms.ToolBarButton();
            this.tbrOpen = new System.Windows.Forms.ToolBarButton();
            this.tbrSave = new System.Windows.Forms.ToolBarButton();
            this.tbrSep1 = new System.Windows.Forms.ToolBarButton();
            this.tbrUndoAllMoves = new System.Windows.Forms.ToolBarButton();
            this.tbrUndoMove = new System.Windows.Forms.ToolBarButton();
            this.tbrResumePlay = new System.Windows.Forms.ToolBarButton();
            this.tbrPausePlay = new System.Windows.Forms.ToolBarButton();
            this.tbrRedoMove = new System.Windows.Forms.ToolBarButton();
            this.tbrRedoAllMoves = new System.Windows.Forms.ToolBarButton();
            this.tbrSep2 = new System.Windows.Forms.ToolBarButton();
            this.tbrFlipBoard = new System.Windows.Forms.ToolBarButton();
            this.tbrSep3 = new System.Windows.Forms.ToolBarButton();
            this.tbrThink = new System.Windows.Forms.ToolBarButton();
            this.tbrSep4 = new System.Windows.Forms.ToolBarButton();
            this.tbrMoveNow = new System.Windows.Forms.ToolBarButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lvwMoveHistory = new System.Windows.Forms.ListView();
            this.lvcMoveNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcMove = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBlacksCaptures = new System.Windows.Forms.Label();
            this.lblWhitesCaptures = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblBlackClock = new System.Windows.Forms.Label();
            this.lblBlackPosition = new System.Windows.Forms.Label();
            this.lblBlackScore = new System.Windows.Forms.Label();
            this.comboBlack = new System.Windows.Forms.ComboBox();
            this.lblBlackPoints = new System.Windows.Forms.Label();
            this.lblWhiteClock = new System.Windows.Forms.Label();
            this.lblWhitePosition = new System.Windows.Forms.Label();
            this.lblWhiteScore = new System.Windows.Forms.Label();
            this.comboWhite = new System.Windows.Forms.ComboBox();
            this.lblWhitePoints = new System.Windows.Forms.Label();
            this.lblPlayerClocks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbr = new System.Windows.Forms.ProgressBar();
            this.lblStage = new System.Windows.Forms.Label();
            this.pnlEdging = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.imgTiles = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgToolMenus
            // 
            this.imgToolMenus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgToolMenus.ImageStream")));
            this.imgToolMenus.TransparentColor = System.Drawing.Color.Transparent;
            this.imgToolMenus.Images.SetKeyName(0, "");
            this.imgToolMenus.Images.SetKeyName(1, "");
            this.imgToolMenus.Images.SetKeyName(2, "");
            this.imgToolMenus.Images.SetKeyName(3, "");
            this.imgToolMenus.Images.SetKeyName(4, "");
            this.imgToolMenus.Images.SetKeyName(5, "");
            this.imgToolMenus.Images.SetKeyName(6, "");
            this.imgToolMenus.Images.SetKeyName(7, "");
            this.imgToolMenus.Images.SetKeyName(8, "");
            this.imgToolMenus.Images.SetKeyName(9, "");
            this.imgToolMenus.Images.SetKeyName(10, "");
            this.imgToolMenus.Images.SetKeyName(11, "");
            // 
            // tbr
            // 
            this.tbr.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbr.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbrNew,
            this.tbrOpen,
            this.tbrSave,
            this.tbrSep1,
            this.tbrUndoAllMoves,
            this.tbrUndoMove,
            this.tbrResumePlay,
            this.tbrPausePlay,
            this.tbrRedoMove,
            this.tbrRedoAllMoves,
            this.tbrSep2,
            this.tbrFlipBoard,
            this.tbrSep3,
            this.tbrThink,
            this.tbrSep4,
            this.tbrMoveNow});
            this.tbr.DropDownArrows = true;
            this.tbr.ImageList = this.imgToolMenus;
            this.tbr.Location = new System.Drawing.Point(0, 0);
            this.tbr.Name = "tbr";
            this.tbr.ShowToolTips = true;
            this.tbr.Size = new System.Drawing.Size(690, 28);
            this.tbr.TabIndex = 33;
            this.tbr.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.tbr.Wrappable = false;
            this.tbr.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbr_ButtonClick);
            // 
            // tbrNew
            // 
            this.tbrNew.ImageIndex = 0;
            this.tbrNew.Name = "tbrNew";
            this.tbrNew.Tag = "New";
            this.tbrNew.ToolTipText = "Start a new chess game";
            // 
            // tbrOpen
            // 
            this.tbrOpen.ImageIndex = 1;
            this.tbrOpen.Name = "tbrOpen";
            this.tbrOpen.Tag = "Open";
            this.tbrOpen.ToolTipText = "Open a saved chess game";
            // 
            // tbrSave
            // 
            this.tbrSave.ImageIndex = 2;
            this.tbrSave.Name = "tbrSave";
            this.tbrSave.Tag = "Save";
            this.tbrSave.ToolTipText = "Save the current chess game";
            // 
            // tbrSep1
            // 
            this.tbrSep1.Name = "tbrSep1";
            this.tbrSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbrUndoAllMoves
            // 
            this.tbrUndoAllMoves.ImageIndex = 6;
            this.tbrUndoAllMoves.Name = "tbrUndoAllMoves";
            this.tbrUndoAllMoves.Tag = "UndoAllMoves";
            this.tbrUndoAllMoves.ToolTipText = "Undo all moves played so far";
            // 
            // tbrUndoMove
            // 
            this.tbrUndoMove.ImageIndex = 4;
            this.tbrUndoMove.Name = "tbrUndoMove";
            this.tbrUndoMove.Tag = "UndoMove";
            this.tbrUndoMove.ToolTipText = "Undo the last move";
            // 
            // tbrResumePlay
            // 
            this.tbrResumePlay.ImageIndex = 8;
            this.tbrResumePlay.Name = "tbrResumePlay";
            this.tbrResumePlay.Tag = "ResumePlay";
            this.tbrResumePlay.ToolTipText = "Resume play";
            // 
            // tbrPausePlay
            // 
            this.tbrPausePlay.Enabled = false;
            this.tbrPausePlay.ImageIndex = 9;
            this.tbrPausePlay.Name = "tbrPausePlay";
            this.tbrPausePlay.Tag = "PausePlay";
            this.tbrPausePlay.ToolTipText = "Pause play";
            // 
            // tbrRedoMove
            // 
            this.tbrRedoMove.ImageIndex = 5;
            this.tbrRedoMove.Name = "tbrRedoMove";
            this.tbrRedoMove.Tag = "RedoMove";
            this.tbrRedoMove.ToolTipText = "Redo move";
            // 
            // tbrRedoAllMoves
            // 
            this.tbrRedoAllMoves.ImageIndex = 7;
            this.tbrRedoAllMoves.Name = "tbrRedoAllMoves";
            this.tbrRedoAllMoves.Tag = "RedoAllMoves";
            this.tbrRedoAllMoves.ToolTipText = "Redo all moves";
            // 
            // tbrSep2
            // 
            this.tbrSep2.Name = "tbrSep2";
            this.tbrSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbrFlipBoard
            // 
            this.tbrFlipBoard.ImageIndex = 10;
            this.tbrFlipBoard.Name = "tbrFlipBoard";
            this.tbrFlipBoard.Tag = "FlipBoard";
            this.tbrFlipBoard.Text = "Flip Board";
            // 
            // tbrSep3
            // 
            this.tbrSep3.Name = "tbrSep3";
            this.tbrSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbrThink
            // 
            this.tbrThink.ImageIndex = 3;
            this.tbrThink.Name = "tbrThink";
            this.tbrThink.Tag = "Think";
            this.tbrThink.Text = "Think";
            this.tbrThink.ToolTipText = "Make the computer play the next move";
            // 
            // tbrSep4
            // 
            this.tbrSep4.Name = "tbrSep4";
            this.tbrSep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbrMoveNow
            // 
            this.tbrMoveNow.ImageIndex = 11;
            this.tbrMoveNow.Name = "tbrMoveNow";
            this.tbrMoveNow.Tag = "MoveNow";
            this.tbrMoveNow.Text = "Move Now";
            this.tbrMoveNow.ToolTipText = "Make the computer immediately play the best move it has found so far";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.label21);
            this.pnlMain.Controls.Add(this.label20);
            this.pnlMain.Controls.Add(this.label19);
            this.pnlMain.Controls.Add(this.label18);
            this.pnlMain.Controls.Add(this.label17);
            this.pnlMain.Controls.Add(this.label16);
            this.pnlMain.Controls.Add(this.label15);
            this.pnlMain.Controls.Add(this.label14);
            this.pnlMain.Controls.Add(this.label12);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label13);
            this.pnlMain.Controls.Add(this.lvwMoveHistory);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.lblBlacksCaptures);
            this.pnlMain.Controls.Add(this.lblWhitesCaptures);
            this.pnlMain.Controls.Add(this.lblPlayer);
            this.pnlMain.Controls.Add(this.lblBlackClock);
            this.pnlMain.Controls.Add(this.lblBlackPosition);
            this.pnlMain.Controls.Add(this.lblBlackScore);
            this.pnlMain.Controls.Add(this.comboBlack);
            this.pnlMain.Controls.Add(this.lblBlackPoints);
            this.pnlMain.Controls.Add(this.lblWhiteClock);
            this.pnlMain.Controls.Add(this.lblWhitePosition);
            this.pnlMain.Controls.Add(this.lblWhiteScore);
            this.pnlMain.Controls.Add(this.comboWhite);
            this.pnlMain.Controls.Add(this.lblWhitePoints);
            this.pnlMain.Controls.Add(this.lblPlayerClocks);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.pbr);
            this.pnlMain.Controls.Add(this.lblStage);
            this.pnlMain.Controls.Add(this.pnlEdging);
            this.pnlMain.Location = new System.Drawing.Point(0, 21);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(690, 496);
            this.pnlMain.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(338, 361);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 19);
            this.label21.TabIndex = 157;
            this.label21.Text = "h";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(296, 361);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 19);
            this.label20.TabIndex = 156;
            this.label20.Text = "g";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(254, 361);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 19);
            this.label19.TabIndex = 155;
            this.label19.Text = "f";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(212, 361);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 19);
            this.label18.TabIndex = 154;
            this.label18.Text = "e";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(170, 361);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 19);
            this.label17.TabIndex = 153;
            this.label17.Text = "d";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(128, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 19);
            this.label16.TabIndex = 152;
            this.label16.Text = "c";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(86, 361);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 19);
            this.label15.TabIndex = 151;
            this.label15.Text = "b";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 19);
            this.label14.TabIndex = 150;
            this.label14.Text = "a";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 19);
            this.label12.TabIndex = 149;
            this.label12.Text = "8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 148;
            this.label11.Text = "7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 147;
            this.label10.Text = "6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 19);
            this.label9.TabIndex = 146;
            this.label9.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 145;
            this.label8.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 144;
            this.label7.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 143;
            this.label6.Text = "2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 19);
            this.label13.TabIndex = 142;
            this.label13.Text = "1";
            // 
            // lvwMoveHistory
            // 
            this.lvwMoveHistory.BackColor = System.Drawing.SystemColors.Control;
            this.lvwMoveHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcMoveNo,
            this.lvcTime,
            this.lvcMove});
            this.lvwMoveHistory.Location = new System.Drawing.Point(400, 176);
            this.lvwMoveHistory.Name = "lvwMoveHistory";
            this.lvwMoveHistory.Size = new System.Drawing.Size(248, 128);
            this.lvwMoveHistory.TabIndex = 39;
            this.lvwMoveHistory.UseCompatibleStateImageBehavior = false;
            this.lvwMoveHistory.View = System.Windows.Forms.View.Details;
            // 
            // lvcMoveNo
            // 
            this.lvcMoveNo.Text = "#";
            this.lvcMoveNo.Width = 19;
            // 
            // lvcTime
            // 
            this.lvcTime.Text = "Time";
            this.lvcTime.Width = 56;
            // 
            // lvcMove
            // 
            this.lvcMove.Text = "Move";
            this.lvcMove.Width = 169;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 136;
            this.label5.Text = "Black";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 135;
            this.label3.Text = "White";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlacksCaptures
            // 
            this.lblBlacksCaptures.BackColor = System.Drawing.Color.Transparent;
            this.lblBlacksCaptures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlacksCaptures.CausesValidation = false;
            this.lblBlacksCaptures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlacksCaptures.Location = new System.Drawing.Point(644, 428);
            this.lblBlacksCaptures.Name = "lblBlacksCaptures";
            this.lblBlacksCaptures.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBlacksCaptures.Size = new System.Drawing.Size(42, 42);
            this.lblBlacksCaptures.TabIndex = 134;
            this.lblBlacksCaptures.Text = "0";
            this.lblBlacksCaptures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhitesCaptures
            // 
            this.lblWhitesCaptures.BackColor = System.Drawing.Color.Transparent;
            this.lblWhitesCaptures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWhitesCaptures.CausesValidation = false;
            this.lblWhitesCaptures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhitesCaptures.Location = new System.Drawing.Point(644, 384);
            this.lblWhitesCaptures.Name = "lblWhitesCaptures";
            this.lblWhitesCaptures.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWhitesCaptures.Size = new System.Drawing.Size(42, 42);
            this.lblWhitesCaptures.TabIndex = 133;
            this.lblWhitesCaptures.Text = "0";
            this.lblWhitesCaptures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer
            // 
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Location = new System.Drawing.Point(392, 32);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(48, 24);
            this.lblPlayer.TabIndex = 131;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBlackClock
            // 
            this.lblBlackClock.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackClock.CausesValidation = false;
            this.lblBlackClock.ForeColor = System.Drawing.Color.Black;
            this.lblBlackClock.Location = new System.Drawing.Point(552, 64);
            this.lblBlackClock.Name = "lblBlackClock";
            this.lblBlackClock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBlackClock.Size = new System.Drawing.Size(96, 23);
            this.lblBlackClock.TabIndex = 130;
            this.lblBlackClock.Text = ":";
            this.lblBlackClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlackPosition
            // 
            this.lblBlackPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlackPosition.CausesValidation = false;
            this.lblBlackPosition.Location = new System.Drawing.Point(552, 144);
            this.lblBlackPosition.Name = "lblBlackPosition";
            this.lblBlackPosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBlackPosition.Size = new System.Drawing.Size(96, 23);
            this.lblBlackPosition.TabIndex = 128;
            this.lblBlackPosition.Text = "0";
            this.lblBlackPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlackScore
            // 
            this.lblBlackScore.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlackScore.CausesValidation = false;
            this.lblBlackScore.Location = new System.Drawing.Point(552, 96);
            this.lblBlackScore.Name = "lblBlackScore";
            this.lblBlackScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBlackScore.Size = new System.Drawing.Size(96, 23);
            this.lblBlackScore.TabIndex = 127;
            this.lblBlackScore.Text = "0";
            this.lblBlackScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBlack
            // 
            this.comboBlack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBlack.Items.AddRange(new object[] {
            "Human",
            "Computer"});
            this.comboBlack.Location = new System.Drawing.Point(552, 32);
            this.comboBlack.Name = "comboBlack";
            this.comboBlack.Size = new System.Drawing.Size(96, 21);
            this.comboBlack.TabIndex = 126;
            // 
            // lblBlackPoints
            // 
            this.lblBlackPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlackPoints.CausesValidation = false;
            this.lblBlackPoints.Location = new System.Drawing.Point(552, 120);
            this.lblBlackPoints.Name = "lblBlackPoints";
            this.lblBlackPoints.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBlackPoints.Size = new System.Drawing.Size(96, 23);
            this.lblBlackPoints.TabIndex = 125;
            this.lblBlackPoints.Text = "0";
            this.lblBlackPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhiteClock
            // 
            this.lblWhiteClock.BackColor = System.Drawing.Color.Transparent;
            this.lblWhiteClock.CausesValidation = false;
            this.lblWhiteClock.ForeColor = System.Drawing.Color.Black;
            this.lblWhiteClock.Location = new System.Drawing.Point(448, 64);
            this.lblWhiteClock.Name = "lblWhiteClock";
            this.lblWhiteClock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWhiteClock.Size = new System.Drawing.Size(96, 23);
            this.lblWhiteClock.TabIndex = 124;
            this.lblWhiteClock.Text = ":";
            this.lblWhiteClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhitePosition
            // 
            this.lblWhitePosition.BackColor = System.Drawing.Color.Transparent;
            this.lblWhitePosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWhitePosition.CausesValidation = false;
            this.lblWhitePosition.Location = new System.Drawing.Point(448, 144);
            this.lblWhitePosition.Name = "lblWhitePosition";
            this.lblWhitePosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWhitePosition.Size = new System.Drawing.Size(96, 23);
            this.lblWhitePosition.TabIndex = 122;
            this.lblWhitePosition.Text = "0";
            this.lblWhitePosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhiteScore
            // 
            this.lblWhiteScore.BackColor = System.Drawing.Color.Transparent;
            this.lblWhiteScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWhiteScore.CausesValidation = false;
            this.lblWhiteScore.Location = new System.Drawing.Point(448, 96);
            this.lblWhiteScore.Name = "lblWhiteScore";
            this.lblWhiteScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWhiteScore.Size = new System.Drawing.Size(96, 23);
            this.lblWhiteScore.TabIndex = 121;
            this.lblWhiteScore.Text = "0";
            this.lblWhiteScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboWhite
            // 
            this.comboWhite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWhite.Items.AddRange(new object[] {
            "Human",
            "Computer"});
            this.comboWhite.Location = new System.Drawing.Point(448, 32);
            this.comboWhite.Name = "comboWhite";
            this.comboWhite.Size = new System.Drawing.Size(96, 21);
            this.comboWhite.TabIndex = 120;
            // 
            // lblWhitePoints
            // 
            this.lblWhitePoints.BackColor = System.Drawing.Color.Transparent;
            this.lblWhitePoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWhitePoints.CausesValidation = false;
            this.lblWhitePoints.Location = new System.Drawing.Point(448, 120);
            this.lblWhitePoints.Name = "lblWhitePoints";
            this.lblWhitePoints.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWhitePoints.Size = new System.Drawing.Size(96, 23);
            this.lblWhitePoints.TabIndex = 119;
            this.lblWhitePoints.Text = "0";
            this.lblWhitePoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerClocks
            // 
            this.lblPlayerClocks.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerClocks.Location = new System.Drawing.Point(392, 64);
            this.lblPlayerClocks.Name = "lblPlayerClocks";
            this.lblPlayerClocks.Size = new System.Drawing.Size(48, 24);
            this.lblPlayerClocks.TabIndex = 118;
            this.lblPlayerClocks.Text = "Clock";
            this.lblPlayerClocks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(392, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 116;
            this.label2.Text = "Position";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(400, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 115;
            this.label4.Text = "Score";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(400, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 114;
            this.label1.Text = "Points";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(32, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 8);
            this.panel1.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(367, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 352);
            this.panel3.TabIndex = 57;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(24, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 8);
            this.panel4.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(24, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 350);
            this.panel2.TabIndex = 56;
            // 
            // pbr
            // 
            this.pbr.Location = new System.Drawing.Point(0, 472);
            this.pbr.Name = "pbr";
            this.pbr.Size = new System.Drawing.Size(688, 23);
            this.pbr.TabIndex = 54;
            // 
            // lblStage
            // 
            this.lblStage.BackColor = System.Drawing.Color.Transparent;
            this.lblStage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStage.CausesValidation = false;
            this.lblStage.Location = new System.Drawing.Point(376, 358);
            this.lblStage.Name = "lblStage";
            this.lblStage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStage.Size = new System.Drawing.Size(312, 23);
            this.lblStage.TabIndex = 50;
            this.lblStage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEdging
            // 
            this.pnlEdging.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEdging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdging.Location = new System.Drawing.Point(28, 12);
            this.pnlEdging.Name = "pnlEdging";
            this.pnlEdging.Size = new System.Drawing.Size(340, 340);
            this.pnlEdging.TabIndex = 35;
            // 
            // timer
            // 
            this.timer.Interval = 333;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // imgTiles
            // 
            this.imgTiles.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTiles.ImageStream")));
            this.imgTiles.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTiles.Images.SetKeyName(0, "");
            this.imgTiles.Images.SetKeyName(1, "");
            // 
            // FenetreDeJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 539);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tbr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenetreDeJeu";
            this.Text = "Jeu d\'échecs";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgToolMenus;
        private System.Windows.Forms.ToolBar tbr;
        private System.Windows.Forms.ToolBarButton tbrNew;
        private System.Windows.Forms.ToolBarButton tbrOpen;
        private System.Windows.Forms.ToolBarButton tbrSave;
        private System.Windows.Forms.ToolBarButton tbrSep1;
        private System.Windows.Forms.ToolBarButton tbrUndoAllMoves;
        private System.Windows.Forms.ToolBarButton tbrUndoMove;
        private System.Windows.Forms.ToolBarButton tbrResumePlay;
        private System.Windows.Forms.ToolBarButton tbrPausePlay;
        private System.Windows.Forms.ToolBarButton tbrRedoMove;
        private System.Windows.Forms.ToolBarButton tbrRedoAllMoves;
        private System.Windows.Forms.ToolBarButton tbrSep2;
        private System.Windows.Forms.ToolBarButton tbrThink;
        private System.Windows.Forms.ToolBarButton tbrSep4;
        private System.Windows.Forms.ToolBarButton tbrMoveNow;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListView lvwMoveHistory;
        private System.Windows.Forms.ColumnHeader lvcMoveNo;
        private System.Windows.Forms.ColumnHeader lvcTime;
        private System.Windows.Forms.ColumnHeader lvcMove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBlacksCaptures;
        private System.Windows.Forms.Label lblWhitesCaptures;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblBlackClock;
        private System.Windows.Forms.Label lblBlackPosition;
        private System.Windows.Forms.Label lblBlackScore;
        private System.Windows.Forms.ComboBox comboBlack;
        private System.Windows.Forms.Label lblBlackPoints;
        private System.Windows.Forms.Label lblWhiteClock;
        private System.Windows.Forms.Label lblWhitePosition;
        private System.Windows.Forms.Label lblWhiteScore;
        private System.Windows.Forms.ComboBox comboWhite;
        private System.Windows.Forms.Label lblWhitePoints;
        private System.Windows.Forms.Label lblPlayerClocks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar pbr;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.Panel pnlEdging;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ImageList imgTiles;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolBarButton tbrFlipBoard;
        private System.Windows.Forms.ToolBarButton tbrSep3;
    }
}