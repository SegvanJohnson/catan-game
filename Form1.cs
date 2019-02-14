using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrangeCatans
{
    public partial class Catan : Form
    {
        #region Globals
        public static List<PictureBox> LandTiles = new List<PictureBox>();
        public static List<PictureBox> RoadTiles = new List<PictureBox>();
        public static List<PictureBox> settlmentTiles = new List<PictureBox>();
        public static List<Button> PlayerButtons = new List<Button>();
        public static List<Label> LandLbl = new List<Label>();
        gameBoard Game = new gameBoard();
        public static TextBox Output = new TextBox();
        #endregion
        
        public Catan()//game initialization
        {
            
            InitializeComponent();
            Output = tbOutputBox;
            Output.Clear();
            string[] Lines = new string[15];
            Output.Lines = Lines;
            #region AddTiles/Labels
            LandTiles.Add(pbLandTile6_1);
            LandLbl.Add(lbl6_1);
            LandTiles.Add(pbLandTile10_1);
            LandLbl.Add(lbl10_1);
            LandTiles.Add(pbLandTile14_1);
            LandLbl.Add(lbl14_1);
            LandTiles.Add(pbLandTile4_3);
            LandLbl.Add(lbl4_3);
            LandTiles.Add(pbLandTile8_3);
            LandLbl.Add(lbl8_3);
            LandTiles.Add(pbLandTile12_3);
            LandLbl.Add(lbl12_3);
            LandTiles.Add(pbLandTile16_3);
            LandLbl.Add(lbl16_3);
            LandTiles.Add(pbLandTile6_5);
            LandLbl.Add(lbl6_5);
            LandTiles.Add(pbLandTile2_5);
            LandLbl.Add(lbl2_5);
            LandTiles.Add(pbLandTile10_5);
            LandLbl.Add(lbl10_5);
            LandTiles.Add(pbLandTile14_5);
            LandLbl.Add(lbl14_5);
            LandTiles.Add(pbLandTile18_5);
            LandLbl.Add(lbl18_5);
            LandTiles.Add(pbLandTile4_7);
            LandLbl.Add(lbl4_7);
            LandTiles.Add(pbLandTile8_7);
            LandLbl.Add(lbl8_7);
            LandTiles.Add(pbLandTile12_7);
            LandLbl.Add(lbl12_7);
            LandTiles.Add(pbLandTile16_7);
            LandLbl.Add(lbl16_7);
            LandTiles.Add(pbLandTile6_9);
            LandLbl.Add(lbl6_9);
            LandTiles.Add(pbLandTile10_9);
            LandLbl.Add(lbl10_9);
            LandTiles.Add(pbLandTile14_9);
            LandLbl.Add(lbl14_9);
            #endregion

            #region AddRoads
            RoadTiles.Add(pbRoad5_0);
            RoadTiles.Add(pbRoad7_0);
            RoadTiles.Add(pbRoad9_0);
            RoadTiles.Add(pbRoad11_0);
            RoadTiles.Add(pbRoad13_0);
            RoadTiles.Add(pbRoad15_0);
            RoadTiles.Add(pbRoad4_1);
            RoadTiles.Add(pbRoad8_1);
            RoadTiles.Add(pbRoad12_1);
            RoadTiles.Add(pbRoad16_1);
            RoadTiles.Add(pbRoad3_2);
            RoadTiles.Add(pbRoad5_2);
            RoadTiles.Add(pbRoad7_2);
            RoadTiles.Add(pbRoad9_2);
            RoadTiles.Add(pbRoad11_2);
            RoadTiles.Add(pbRoad13_2);
            RoadTiles.Add(pbRoad15_2);
            RoadTiles.Add(pbRoad17_2);
            RoadTiles.Add(pbRoad2_3);
            RoadTiles.Add(pbRoad6_3);
            RoadTiles.Add(pbRoad10_3);
            RoadTiles.Add(pbRoad14_3);
            RoadTiles.Add(pbRoad18_3);
            RoadTiles.Add(pbRoad1_4);
            RoadTiles.Add(pbRoad3_4);
            RoadTiles.Add(pbRoad5_4);
            RoadTiles.Add(pbRoad7_4);
            RoadTiles.Add(pbRoad9_4);
            RoadTiles.Add(pbRoad11_4);
            RoadTiles.Add(pbRoad13_4);
            RoadTiles.Add(pbRoad15_4);
            RoadTiles.Add(pbRoad17_4);
            RoadTiles.Add(pbRoad19_4);
            RoadTiles.Add(pbRoad0_5);
            RoadTiles.Add(pbRoad4_5);
            RoadTiles.Add(pbRoad8_5);
            RoadTiles.Add(pbRoad12_5);
            RoadTiles.Add(pbRoad16_5);
            RoadTiles.Add(pbRoad20_5);
            RoadTiles.Add(pbRoad1_6);
            RoadTiles.Add(pbRoad3_6);
            RoadTiles.Add(pbRoad5_6);
            RoadTiles.Add(pbRoad7_6);
            RoadTiles.Add(pbRoad9_6);
            RoadTiles.Add(pbRoad11_6);
            RoadTiles.Add(pbRoad13_6);
            RoadTiles.Add(pbRoad15_6);
            RoadTiles.Add(pbRoad17_6);
            RoadTiles.Add(pbRoad19_6);
            RoadTiles.Add(pbRoad2_7);
            RoadTiles.Add(pbRoad6_7);
            RoadTiles.Add(pbRoad10_7);
            RoadTiles.Add(pbRoad14_7);
            RoadTiles.Add(pbRoad18_7);
            RoadTiles.Add(pbRoad3_8);
            RoadTiles.Add(pbRoad5_8);
            RoadTiles.Add(pbRoad7_8);
            RoadTiles.Add(pbRoad9_8);
            RoadTiles.Add(pbRoad11_8);
            RoadTiles.Add(pbRoad13_8);
            RoadTiles.Add(pbRoad15_8);
            RoadTiles.Add(pbRoad17_8);
            RoadTiles.Add(pbRoad4_9);
            RoadTiles.Add(pbRoad8_9);
            RoadTiles.Add(pbRoad12_9);
            RoadTiles.Add(pbRoad16_9);
            RoadTiles.Add(pbRoad5_10);
            RoadTiles.Add(pbRoad7_10);
            RoadTiles.Add(pbRoad9_10);
            RoadTiles.Add(pbRoad11_10);
            RoadTiles.Add(pbRoad13_10);
            RoadTiles.Add(pbRoad15_10);
            #endregion

            #region AddSettlements
            settlmentTiles.Add(pbSettle6_0);
            settlmentTiles.Add(pbSettle10_0);
            settlmentTiles.Add(pbSettle14_0);
            settlmentTiles.Add(pbSettle4_0);
            settlmentTiles.Add(pbSettle8_0);
            settlmentTiles.Add(pbSettle12_0);
            settlmentTiles.Add(pbSettle16_0);
            settlmentTiles.Add(pbSettle4_2);
            settlmentTiles.Add(pbSettle8_2);
            settlmentTiles.Add(pbSettle12_2);
            settlmentTiles.Add(pbSettle16_2);
            settlmentTiles.Add(pbSettle2_2);
            settlmentTiles.Add(pbSettle6_2);
            settlmentTiles.Add(pbSettle10_2);
            settlmentTiles.Add(pbSettle14_2);
            settlmentTiles.Add(pbSettle18_2);
            settlmentTiles.Add(pbSettle2_4);
            settlmentTiles.Add(pbSettle6_4);
            settlmentTiles.Add(pbSettle10_4);
            settlmentTiles.Add(pbSettle14_4);
            settlmentTiles.Add(pbSettle18_4);
            settlmentTiles.Add(pbSettle0_4);
            settlmentTiles.Add(pbSettle4_4);
            settlmentTiles.Add(pbSettle8_4);
            settlmentTiles.Add(pbSettle12_4);
            settlmentTiles.Add(pbSettle16_4);
            settlmentTiles.Add(pbSettle20_4);
            settlmentTiles.Add(pbSettle0_6);
            settlmentTiles.Add(pbSettle4_6);
            settlmentTiles.Add(pbSettle8_6);
            settlmentTiles.Add(pbSettle12_6);
            settlmentTiles.Add(pbSettle16_6);
            settlmentTiles.Add(pbSettle20_6);
            settlmentTiles.Add(pbSettle2_6);
            settlmentTiles.Add(pbSettle6_6);
            settlmentTiles.Add(pbSettle10_6);
            settlmentTiles.Add(pbSettle14_6);
            settlmentTiles.Add(pbSettle18_6);
            settlmentTiles.Add(pbSettle2_8);
            settlmentTiles.Add(pbSettle6_8);
            settlmentTiles.Add(pbSettle10_8);
            settlmentTiles.Add(pbSettle14_8);
            settlmentTiles.Add(pbSettle18_8);
            settlmentTiles.Add(pbSettle4_8);
            settlmentTiles.Add(pbSettle8_8);
            settlmentTiles.Add(pbSettle12_8);
            settlmentTiles.Add(pbSettle16_8);
            settlmentTiles.Add(pbSettle4_10);
            settlmentTiles.Add(pbSettle8_10);
            settlmentTiles.Add(pbSettle12_10);
            settlmentTiles.Add(pbSettle16_10);
            settlmentTiles.Add(pbSettle6_10);
            settlmentTiles.Add(pbSettle10_10);
            settlmentTiles.Add(pbSettle14_10);
            #endregion

            #region Button add
            PlayerButtons.Add(btnPlayer1);
            PlayerButtons.Add(btnPlayer2);
            PlayerButtons.Add(btnPlayer3);
            PlayerButtons.Add(btnPlayer4);
            #endregion

            #region Intialize functions

            #endregion

        }

        public class settings
        {
            Random settingsRand = new Random();
            public static int[] landCardAmounts = new int[] { 4,4,4,4,4,1}; //Number of each land: Wood, Grass, Sheep, Brick, Rock, Sand
            public static int[] landCounters = new int[] {0,0,2,2,2,2,2,0,2,2,2,2,2}; //1-12 counters; 0, 1, 2, 3, 4, 5, 6, 7(ignored in the code), 8, 9, 10, 11, 13
            public static int numPlayers = 4;
        }
        
        public class gameBoard
        {
            public static string[] state = new string[] { "Waiting", "0"};
            static List<landTile> LandInfo = new List<landTile>();
            static List<SettleTiles> SettleInfo = new List<SettleTiles>();
            static List<RoadTile> RoadInfo = new List<RoadTile>();
            static Players Player = new Players();
            public stateMachince State = new stateMachince();
            public static int[] Thief = new int[] { 0, 0 };

            private static int[,] locationNums = new int[,]{ {0,-1}, {1,-1}, {2,-1}, {2,0},{2,1}, {1,1}, {0,1}, {-1,1}, {-2,1}, {-2,0}, {-2,-1}, {-1,-1} };
                        //Starts with the top settlement and then goes clockwise around
            public void Initialize()
            {
                LandInfo.Clear();
                SettleInfo.Clear();
                RoadInfo.Clear();
                Player.Main();
                for (int I = 0; I < 19; I++)
                {
                    landTile tempLand = new landTile();
                    tempLand.Initialize(LandTiles[I], LandLbl[I]);

                    int numpull;
                    if (LandLbl[I].Text == "Blank")
                    {
                        throw new Exception("No Roll Number was passed.");
                    }
                    else
                    {
                        int.TryParse(LandLbl[I].Text.Substring(0,LandLbl[I].Text.IndexOf(' ')), out numpull);
                    }
                    tempLand.RollNum = numpull;
                    if (tempLand.thiefed)
                    {
                        Thief[0] = tempLand.posX;
                        Thief[1] = tempLand.posY;
                    }
                    LandInfo.Add(tempLand);
                }
                foreach(PictureBox x in settlmentTiles)
                {
                    SettleTiles tempSettle = new SettleTiles();
                    tempSettle.Initialize(x);
                    SettleInfo.Add(tempSettle);

                }
                foreach (PictureBox x in RoadTiles)
                {
                    RoadTile tempRoad = new RoadTile();
                    tempRoad.Initialize(x);
                    RoadInfo.Add(tempRoad);

                }
                state[0] = "New Game";

            }

            class landTile
            {
                public PictureBox Land { get; set; }
                public Label LandLbl { get; set; }
                public string landType { get; set; }
                public int RollNum { get; set; }
                public int posX { get; set; }
                public int posY { get; set; }
                public bool thiefed = false;

                public void Initialize(PictureBox land, Label lblPass)
                {
                    this.Land = land;
                    this.LandLbl = lblPass;
                    string XYgetter = land.Name.Substring(10);
                    int tempX, tempY;
                    int.TryParse(XYgetter.Substring(0, XYgetter.IndexOf('_')), out tempX);
                    int.TryParse(XYgetter.Substring(XYgetter.IndexOf('_') + 1), out tempY);
                    posX = tempX;
                    posY = tempY;
                    landType = getLandtype(lblPass);
                    if(landType == "Sand")
                    {
                        thiefed = true;
                        outputstring("Desert at " + posX + ", " + posY);
                    }

                }

                public string getLandtype(Label lblParse)
                {
                    string lblname = lblParse.Text.Substring(lblParse.Text.IndexOf(' ')+1);
                    if (lblname == "Brick")
                    {
                        return "Brick";
                    }
                    else if (lblname == "Grass")
                    {
                        return "Grass";
                    }
                    else if (lblname == "Rock")
                    {
                        return "Rock";
                    }
                    else if (lblname == "Desert(Thiefed)")
                    {
                        return "Sand";
                    }
                    else if (lblname == "Sheep")
                    {
                        return "Sheep";
                    }
                    else if (lblname == "Wood")
                    {
                        return "Wood";
                    }
                    else if (lblname == "Water")
                    {
                        return "Water";
                    }
                    else
                    {
                        return "Error";
                    }
                }
            }

            public class SettleTiles
            {
                public PictureBox settlement { get; set; }
                public int PosX { get; set; }
                public int PosY { get; set; }
                public string type { get; set; }
                public string owner = null;
                public bool available = true;
                public bool roadNorth { get; set; } //makes sure where to look later

                public void Initialize(PictureBox settlement)
                {
                    this.settlement = settlement;
                    string XYgetter = settlement.Name.Substring(8);
                    int tempX, tempY;
                    int.TryParse(XYgetter.Substring(0, XYgetter.IndexOf('_')), out tempX);
                    int.TryParse(XYgetter.Substring(XYgetter.IndexOf('_') + 1), out tempY);
                    PosX = tempX;
                    PosY = tempY;
                    this.type = "plot";
                    if (PosX == 0 || PosX == 4 || PosX == 8 || PosX == 12 || PosX == 16 || PosX == 20)
                    {
                        if (PosY == 0 || PosY == 4 || PosY == 8)
                        {
                            roadNorth = false;
                        }
                        else
                        {
                            roadNorth = true;
                        }
                    }
                    else
                    {
                        if (PosY == 0 || PosY == 4 || PosY == 8)
                        {
                            roadNorth = true;
                        }
                        else
                        {
                            roadNorth = false;
                        }
                    }
                }
            }

            public class RoadTile
            {
                public PictureBox road { get; set; }
                public int PosX { get; set; }
                public int PosY { get; set; }
                public string owner = null;
                public bool available = false;
                public List<Players.Player> availableTo = new List<Players.Player>();
                public bool VertHorz { get; set; } //True = Vertical; False = Horizontal

                public void Initialize(PictureBox road)
                {
                    this.road = road;
                    string XYgetter = road.Name.Substring(6);
                    int tempX, tempY;
                    int.TryParse(XYgetter.Substring(0, XYgetter.IndexOf('_')), out tempX);
                    int.TryParse(XYgetter.Substring(XYgetter.IndexOf('_') + 1), out tempY);
                    PosX = tempX;
                    PosY = tempY;
                    if (this.PosY == 0 || this.PosY == 2 || this.PosY == 4 || this.PosY == 6 || this.PosY == 8 || this.PosY == 10)
                    {
                        this.VertHorz = false;
                    }
                    else
                    {
                        this.VertHorz = true;
                    }
                }
            }

            public class Players
            {
                public Dictionary<string, Player> playerFind = new Dictionary<string, Player>();
                public List<Player> PlayerPlayOrder = new List<Player>();
                List<string> PlayerColors = new List<string> { "Orange", "Red", "Green", "Blue" };
                public void Main()
                {
                    PlayerPlayOrder.Clear();
                    for (int i = 0; i < settings.numPlayers; i++)
                    {
                        PlayerPlayOrder.Add(new Player());
                        PlayerPlayOrder[i].playerColor = Color.FromName(PlayerColors[i]);
                        PlayerPlayOrder[i].PlayerName = PlayerColors[i];
                        PlayerPlayOrder[i].playerButton = PlayerButtons[i];
                        PlayerPlayOrder[i].playerButton.Text = PlayerPlayOrder[i].PlayerName;
                        PlayerPlayOrder[i].Resources.Add("Wood", 0);
                        PlayerPlayOrder[i].Resources.Add("Sheep", 0);
                        PlayerPlayOrder[i].Resources.Add("Grass", 0);
                        PlayerPlayOrder[i].Resources.Add("Brick", 0);
                        PlayerPlayOrder[i].Resources.Add("Rock", 0);
                        outputstring(PlayerPlayOrder[i].PlayerName);
                        playerFind.Add(PlayerPlayOrder[i].PlayerName, PlayerPlayOrder[i]);
                    }
                }

                public string currentPlayer()
                {
                    return PlayerPlayOrder[0].PlayerName;
                }

                public void NextTurn()
                {
                    PlayerPlayOrder.Add(PlayerPlayOrder[0]);
                    PlayerPlayOrder.RemoveAt(0);
                    outputstring(PlayerPlayOrder[0].PlayerName + "'s turn.");
                }

                public void newGameReversal()
                {
                    PlayerPlayOrder.Add(PlayerPlayOrder[0]);
                    PlayerPlayOrder.RemoveAt(0);
                    PlayerPlayOrder.Reverse();
                }

                public class Player
                {
                    public Dictionary<string, int> Resources = new Dictionary<string, int>();
                    public Button playerButton = new Button();
                    public Color playerColor = new Color();
                    public string PlayerName { get; set; }
                    public List<SettleTiles> PlayerSettlements = new List<SettleTiles>();
                    public List<RoadTile> PlayerRoads = new List<RoadTile>();
                    public List<object> PlayerCards = new List<object>();
                }
            }

            public class stateMachince
            {
                Dictionary<String, Action<int>> StateDictionary = new Dictionary<string, Action<int>>();
                string[,] stringStack = new string[5,2];
                #region Fill Dict
                #endregion

                #region methods

                public void ClickHandler(string button, int posX = 0, int posY = 0)
                {
                    switch (button)
                    {
                        case "Buy Card":
                            break;
                        case "Trade":
                            break;
                        case "Roll":
                            if(state[0] == "Waiting" && state[1] == "0")
                            {
                                roll();
                            } else
                            {
                                outputstring("You have already rolled this turn.");
                            }
                            break;
                        case "EndTurn":
                            if(state[0] == "Waiting" && state[1] == "1") {
                                Player.NextTurn();
                                state[0] = "Waiting";
                                state[1] = "0";
                            } else if (state[0] == "Waiting" && state[1] == "0")
                            {
                                outputstring("Please roll before ending your turn.");
                            } else
                            {
                                //cancel whatever action.
                            }
                            
                            break;
                        case "New Game":
                            newGame(state[1]);
                            break;
                        case "Land":
                            landClick(posX, posY);
                            break;
                        case "Settlement":
                            if(state[0]=="Thief")
                            {
                                thief(state[1], posX, posY);
                            }
                            else if (state[0] == "New Game")
                            {
                                newGame(state[1], posX, posY);
                            }
                            break;
                        case "Road":
                            if(state[0]=="New Game")
                            {
                                newGame(state[1], posX, posY);
                            }
                            break;
                        case "Player 1":
                            if(Player.PlayerPlayOrder[0].PlayerName == "Orange")
                            {
                                displayResourses(Player.PlayerPlayOrder[0], true);
                            } else
                            {
                                displayResourses(Player.playerFind["Orange"]);
                            }

                            break;
                        case "Player 2":
                            if (Player.PlayerPlayOrder[0].PlayerName == "Red")
                            {
                                displayResourses(Player.PlayerPlayOrder[0], true);
                            }
                            else
                            {
                                displayResourses(Player.playerFind["Red"]);
                            }
                            break;
                        case "Player 3":
                            if (Player.PlayerPlayOrder[0].PlayerName == "Green")
                            {
                                displayResourses(Player.PlayerPlayOrder[0], true);
                            }
                            else
                            {
                                displayResourses(Player.playerFind["Green"]);
                            }
                            break;
                        case "Player 4":
                            if (Player.PlayerPlayOrder[0].PlayerName == "Blue")
                            {
                                displayResourses(Player.PlayerPlayOrder[0], true);
                            }
                            else
                            {
                                displayResourses(Player.playerFind["Blue"]);
                            }
                            break;
                        default:
                            outputstring(button);
                            break;
                    }
                }

                #region newgame shite
                void newGame(string status, int posX = 0, int posY = 0)
                {
                    switch (status)
                    {
                        case "0":
                            outputstring(Player.PlayerPlayOrder[0].PlayerName + ", Please click a settlement to buy.");
                            state[1] = "1";
                            break;
                        case "1":
                            if(posX != 0 || posY != 0) {
                                if(newGameSettleBuy(posX, posY))
                                {
                                    outputstring("Now choose a connected road.");
                                    state[1] = "2";
                                }
                            } else {
                                outputstring("Please pick a settlement location.");
                            }
                            break;
                        case "2":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameRoadBuy(posX, posY))
                                {
                                    Player.NextTurn();
                                    outputstring("Please pick a settlement location.");
                                    state[1] = "3";
                                }
                                else
                                {
                                    outputstring("Please pick a proper road location.");
                                }
                            }
                            else
                            {
                                outputstring("Please pick a road location.");
                            }
                            break;
                        case "3":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameSettleBuy(posX, posY))
                                {
                                    outputstring("Now choose a connected road.");
                                    state[1] = "4";
                                }
                            }
                            else
                            {
                                outputstring("Please pick a settlement location.");
                            }
                            break;
                        case "4":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameRoadBuy(posX, posY))
                                {
                                    Player.NextTurn();
                                    outputstring("Please pick a settlement location.");
                                    state[1] = "5";
                                }
                                else
                                {
                                    outputstring("Please pick a proper road location.");
                                }
                            }
                            else
                            {
                                outputstring("Please pick a road location.");
                            }
                            break;
                        case "5":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameSettleBuy(posX, posY))
                                {
                                    outputstring("Now choose a connected road.");
                                    state[1] = "6";
                                }
                            }
                            else
                            {
                                outputstring("Please pick a settlement location.");
                            }
                            break;
                        case "6":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameRoadBuy(posX, posY))
                                {
                                    Player.NextTurn();
                                    outputstring("Please pick a settlement location.");
                                    state[1] = "7";
                                }
                                else
                                {
                                    outputstring("Please pick a proper road location.");
                                }
                            }
                            else
                            {
                                outputstring("Please pick a road location.");
                            }
                            break;
                        case "7":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameSettleBuy(posX, posY))
                                {
                                    outputstring("Now choose a connected road.");
                                    state[1] = "8";
                                }
                            }
                            else
                            {
                                outputstring("Please pick a settlement location.");
                            }
                            break;
                        case "8":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameRoadBuy(posX, posY))
                                {
                                    Player.newGameReversal();
                                    outputstring(Player.currentPlayer() + ": Please pick a settlement location again.");
                                    state[1] = "9";
                                }
                                else
                                {
                                    outputstring("Please pick a proper road location.");
                                }
                            }
                            else
                            {
                                outputstring("Please pick a road location.");
                            }
                            break;
                        case "9":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameSettleBuy(posX, posY, 2))
                                {
                                    outputstring("Now choose a connected road.");
                                    state[1] = "10";
                                }
                            }
                            else
                            {
                                outputstring("Please pick a settlement location.");
                            }
                            break;
                        case "10":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameRoadBuy(posX, posY, 2))
                                {
                                    Player.NextTurn();
                                    outputstring("Please pick a settlement location.");
                                    state[1] = "11";
                                }
                                else
                                {
                                    outputstring("Please pick a proper road location.");
                                }
                            }
                            else
                            {
                                outputstring("Please pick a road location.");
                            }
                            break;
                        case "11":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameSettleBuy(posX, posY, 2))
                                {
                                    outputstring("Now choose a connected road.");
                                    state[1] = "12";
                                }
                            }
                            else
                            {
                                outputstring("Please pick a settlement location.");
                            }
                            break;
                        case "12":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameRoadBuy(posX, posY, 2))
                                {
                                    Player.NextTurn();
                                    outputstring("Please pick a settlement location.");
                                    state[1] = "13";
                                }
                                else
                                {
                                    outputstring("Please pick a proper road location.");
                                }
                            }
                            else
                            {
                                outputstring("Please pick a road location.");
                            }
                            break;
                        case "13":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameSettleBuy(posX, posY, 2))
                                {
                                    outputstring("Now choose a connected road.");
                                    state[1] = "14";
                                }
                            }
                            else
                            {
                                outputstring("Please pick a settlement location.");
                            }
                            break;
                        case "14":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameRoadBuy(posX, posY, 2))
                                {
                                    Player.NextTurn();
                                    outputstring("Please pick a settlement location.");
                                    state[1] = "15";
                                }
                                else
                                {
                                    outputstring("Please pick a proper road location.");
                                }
                            }
                            else
                            {
                                outputstring("Please pick a road location.");
                            }
                            break;
                        case "15":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameSettleBuy(posX, posY))
                                {
                                    outputstring("Now choose a connected road.");
                                    state[1] = "16";
                                }
                            }
                            else
                            {
                                outputstring("Please pick a settlement location.");
                            }
                            break;
                        case "16":
                            if (posX != 0 || posY != 0)
                            {
                                if (newGameRoadBuy(posX, posY, 2))
                                {
                                    Player.newGameReversal();
                                    outputstring(Player.currentPlayer() + ": Its your turn.");
                                    state[0] = "Waiting";
                                    state[1] = "0";
                                }
                                else
                                {
                                    outputstring("Please pick a proper road location.");
                                }
                            }
                            else
                            {
                                outputstring("Please pick a road location.");
                            }
                            break;
                    }
                }

                bool newGameSettleBuy(int posX, int posY, int iteration = 1)
                {
                    foreach (SettleTiles x in SettleInfo)
                    {
                        if (posX == x.PosX && posY == x.PosY && x.available)
                        {
                            Player.PlayerPlayOrder[0].PlayerSettlements.Add(x);
                            x.settlement.BackColor = Player.PlayerPlayOrder[0].playerColor;
                            x.settlement.Image = Properties.Resources.settlementSettlement;
                            foreach (RoadTile y in RoadInfo)
                            {
                                if ((y.PosX == x.PosX && (y.PosY == (x.PosY - 1) || y.PosY == (x.PosY + 1))) && y.owner == null)
                                {
                                    y.road.BackColor = Color.Yellow;
                                    y.available = true;
                                    y.availableTo.Add(Player.PlayerPlayOrder[0]);
                                }
                                else if ((y.PosY == x.PosY && (y.PosX == (x.PosX - 1) || y.PosX == (x.PosX + 1))) && y.owner == null)
                                {
                                    y.road.BackColor = Color.Yellow;
                                    y.available = true;
                                    y.availableTo.Add(Player.PlayerPlayOrder[0]);
                                }
                            }
                            foreach (SettleTiles y in SettleInfo)
                            {
                                if ((y.PosX == x.PosX) && ((!y.roadNorth && (y.PosY == (x.PosY - 2))) || (y.roadNorth && (y.PosY == (x.PosY + 2)))))
                                {
                                    y.settlement.BackColor = Color.Gray;
                                    y.available = false;
                                }
                                else if ((y.PosY == x.PosY) && ((y.PosX == (x.PosX - 2)) ||  (y.PosX == (x.PosX + 2))))
                                {
                                    y.settlement.BackColor = Color.Gray;
                                    y.available = false;
                                }
                            }
                            break;
                        }
                    }
                    if (Player.PlayerPlayOrder[0].PlayerSettlements.Count < iteration)
                    {
                        return false;
                    } else
                    {
                        return true;
                    }
                }

                bool newGameRoadBuy(int posX, int posY, int iteration = 1)
                {
                    foreach (RoadTile x in RoadInfo)
                    {
                        if (posX == x.PosX && posY == x.PosY && x.available)
                        {
                            x.road.BackColor = Player.PlayerPlayOrder[0].playerColor;
                            x.available = false;
                            x.owner = Player.PlayerPlayOrder[0].PlayerName;
                            Player.PlayerPlayOrder[0].PlayerRoads.Add(x);
                            break;
                        }
                    }
                    if (Player.PlayerPlayOrder[0].PlayerRoads.Count < iteration)
                    {
                        return false;
                    } else
                    {
                        return true;
                    }
                }
                #endregion

                void displayResourses(Players.Player jeff, bool playerTurn = false)
                {
                    if (playerTurn)
                    {
                        outputstring("Wood: " + jeff.Resources["Wood"].ToString());
                        outputstring("Sheep: " + jeff.Resources["Sheep"].ToString());
                        outputstring("Grass: " + jeff.Resources["Grass"].ToString());
                        outputstring("Brick: " + jeff.Resources["Brick"].ToString());
                        outputstring("Rock: " + jeff.Resources["Rock"].ToString());
                    } else
                    {
                        int resourses = 0;
                        foreach(KeyValuePair<string,int> x in jeff.Resources)
                        {
                            resourses += x.Value;
                        }
                        outputstring(jeff.PlayerName + " has " + resourses + " cards.");
                    }
                }

                void landClick(int posX, int posY)
                {
                    if (state[0] == "Thief")
                    {
                        thief(state[1], posX, posY);
                    }
                }

                void thief(string status, int posX = 0, int posY = 0)
                {
                    switch (status)
                    {
                        case "0":
                            if (posX == 0 && posY == 0)
                            {
                                outputstring("Please select a valid land tile");
                            }
                            else
                            {
                                foreach (landTile x in LandInfo)
                                {
                                    if ((posX == x.posX && posY == x.posY) && x.thiefed)
                                    {
                                        outputstring("You cannot put the Thief on the same landtile.");
                                    } else { 
                                        if (x.thiefed)
                                        {
                                            x.thiefed = false;
                                            x.LandLbl.Text = x.RollNum + " " + x.landType;
                                        }
                                        if (x.posX == posX && x.posY == posY)
                                        {
                                            x.thiefed = true;
                                            x.LandLbl.Text = x.RollNum + " " + x.landType + " Thiefed";
                                            outputstring("No more " + x.landType + " from all in the area: " + x.posX + "," + x.posY);
                                            Thief[0] = posX;
                                            Thief[1] = posY;
                                            state[1] = "1";
                                        }
                                    }
                                }
                            }
                            break;
                        case "1":
                            for (int i = 0; i < 12; i += 2)
                            {
                                if (posX == (locationNums[i, 0] + Thief[0]) && posY == (locationNums[i, 1] + Thief[1]))
                                {
                                    outputstring("The settlement at " + (locationNums[i, 0] + Thief[0]) + "," + (locationNums[i, 1] + Thief[1]) + " was hit.");
                                    state[0] = "Waiting";
                                    state[1] = "1";
                                }
                            }
                            break;
                    }
                }

                void roll()
                {
                    if(state[0] == "Waiting" && state[1] == "0")
                    {
                        int rolled = twelveNum();
                        outputstring(Player.PlayerPlayOrder[0].PlayerName + " rolled a " + rolled);
                        if(rolled == 7)
                        {
                            state[0] = "Thief";
                            state[1] = "0";
                            outputstring("THIEF ROLL.");
                            outputstring("Please move the thief to a land tile.");
                            //BeginThief();
                        } else {
                            #region basic Roll
                            foreach (landTile x in LandInfo)
                            {
                                if(x.RollNum == rolled && !x.thiefed)
                                {
                                    for(int i = 0; i < 12; i += 2)
                                    {
                                        int checkPosX = x.posX + locationNums[i,0];
                                        int checkPosY = x.posY + locationNums[i,1];
                                        foreach(Players.Player y in Player.PlayerPlayOrder)
                                        {
                                            foreach(SettleTiles z in y.PlayerSettlements)
                                            {
                                                if(z.PosX == checkPosX && z.PosY == checkPosY)
                                                {
                                                    if(x.landType != "Sand")
                                                    {
                                                        y.Resources[x.landType]++;
                                                        if(z.type == "City")
                                                        {
                                                            y.Resources[x.landType]++;
                                                        }
                                                        outputstring(y.PlayerName + " gets " + x.landType);
                                                    }
                                                    
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            state[1] = "1";
                            #endregion
                        }
                        

                    }
                }

                public int twelveNum()
                {
                    Random quick = new Random((int)DateTime.Now.Ticks);
                    return quick.Next(2, 12);
                }
                public int[] twodi()
                {
                    Random quick = new Random((int)DateTime.Now.Ticks);
                    int[] numOut = new int[] { quick.Next(1, 6), quick.Next(1, 6) };
                    return numOut;
                }
                #endregion
            }
            
        }

        #region board initialization
        public void RandBoard()
        {
            Random boardRander = new Random();
            int[,] landNums = new int[19, 2];
            bool boardPopulated = false;
            int positionCounter = 0;
            int[] landTypeCounts = new int[] { 0, 0, 0, 0, 0, 0};
            int[] landNumCounts = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0 };
            while (!boardPopulated)
            {
                int[] landFiller = new int[2];
                int roller = boardRander.Next(0, 5);
                bool landchecker = false;
                while (!landchecker)
                {
                    if (landTypeCounts[roller] < settings.landCardAmounts[roller])
                    {
                        landTypeCounts[roller] += 1;
                        landchecker = true;
                    }
                    else
                    {
                        roller = boardRander.Next(0, 6);
                    }
                }
                landFiller[0] = roller;
                roller = boardRander.Next(2, 13);
                landchecker = false;
                while (!landchecker)
                {
                    if (landNumCounts[roller] < settings.landCounters[roller])
                    {
                        landNumCounts[roller] += 1;
                        landchecker = true;
                    }
                    else
                    {
                        roller = boardRander.Next(2, 13);
                    }
                }
                landFiller[1] = roller;
                landNums[positionCounter, 0] = landFiller[0];
                landNums[positionCounter, 1] = landFiller[1];
                positionCounter += 1;
                if (positionCounter > 18)
                {
                    boardPopulated = true;
                }
            }
            if(landTypeCounts[5] == 0)
            {
                landNums[boardRander.Next(0, 19), 0] = 5;
            }
            PopulateBoard(landNums, LandTiles, LandLbl);

        }

        public static void PopulateBoard(int[,] boardStats, List<PictureBox> MapTiles, List<Label> Labels)
        {
            if(boardStats.Length != (19 * 2))
            {
                throw new Exception("Board not filled");
            }
            bool sand = false;
            for(int I = 0; I < 19; I++)
            {
                string landtype = "";
                switch (boardStats[I, 0])
                {
                    case 0: //wood
                    MapTiles[I].Image = Properties.Resources.wood;
                        landtype = "Wood";
                        break;
                    case 1: //grass
                        MapTiles[I].Image = Properties.Resources.Grass;
                        landtype = "Grass";
                    break;
                    case 2: //Sheep
                        MapTiles[I].Image = Properties.Resources.Sheep;
                        landtype = "Sheep";
                    break;
                    case 3: //brick
                        MapTiles[I].Image = Properties.Resources.Brick;
                        landtype = "Brick";
                    break;
                    case 4: //ore
                        MapTiles[I].Image = Properties.Resources.Rock;
                        landtype = "Rock";
                    break;
                    case 5: //Desert
                        MapTiles[I].Image = Properties.Resources.sand;
                        landtype = "Desert";
                        sand = true;
                    break;
                    case 6: //water?
                        MapTiles[I].Image = Properties.Resources.Water;
                    break;
                }
                Labels[I].Text = boardStats[I, 1].ToString() + " " + landtype;
                if (sand)
                {
                    Labels[I].Text += "(Thiefed)";
                    sand = false;
                }
                    
            }

        }
        #endregion

        public static void outputstring(string addLine) //convinient for debugging and knowing what the game wants
        {
            Output.ReadOnly = false;
            Output.Text = Output.Text.Substring(Output.Lines[0].Length + 2);
            Output.Text += addLine + "\r\n";
            Output.ReadOnly = true;
        }
        
        #region Buttons
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 7,0 );
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHand_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Hand");
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("EndTurn");
        }           //Next Turn button

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Build");
        }

        private void btnBuyCard_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Buy Card");
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Build");
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Trade");
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Roll");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Player 1");
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Player 2");
        }

        private void btnPlayer3_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Player 3");
        }

        private void btnPlayer4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Player 4");
        }

        private void button1_Click(object sender, EventArgs e) //new game
        {
            RandBoard();
            Game.Initialize();
            Game.State.ClickHandler("New Game");
            btnNewGame.Enabled = false;
        }
        #endregion
        
        #region Map Clicks
        private void pbLandTile6_1_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 6, 1);
        }

        private void pbLandTile10_1_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 10, 1);
        }
        private void pbLandTile4_3_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 4, 3);
        }

        private void pbLandTile14_1_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 14, 1);
        }

        private void pbSettle4_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 4, 0);
        }

        private void pbSettle6_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 6, 0);
        }

        private void pbSettle8_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 8, 0);
        }

        private void pbSettle10_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 10, 0);
        }

        private void pbSettle12_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 12, 0);
        }

        private void pbSettle14_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 14, 0);
        }

        private void pbSettle16_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 16, 0);
        }
        

        private void pbSettle4_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 4, 2);
        }

        private void pbSettle8_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 8,2);
        }

        private void pbSettle12_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 12, 2);
        }

        private void pbSettle16_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 16, 2);
        }

        private void pbSettle2_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 2, 2);
        }

        private void pbSettle6_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 6, 2);
        }

        private void pbSettle10_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 10, 2);
        }

        private void pbSettle14_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 14, 2);
        }

        private void pbSettle18_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 18, 2);
        }

        private void pbSettle2_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 2, 4);
        }

        private void pbSettle6_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 6, 4);
        }

        private void pbSettle10_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 10, 4);
        }

        private void pbSettle14_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 14, 4);
        }

        private void pbSettle18_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 18, 4);
        }

        private void pbSettle0_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 0, 4);
        }

        private void pbSettle4_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 4, 4);
        }

        private void pbSettle8_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 8, 4);
        }

        private void pbSettle12_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 12, 4);
        }

        private void pbLandTile18_5_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 18, 5);
        }

        private void pbSettle16_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 16, 4);
        }

        private void pbSettle20_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 20, 4);
        }
        

        private void pbRoad5_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 5,0 );
        }

        private void pbRoad9_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 9,0 );
        }

        private void pbRoad11_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 11,0 );
        }

        private void pbRoad13_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 13,0 );
        }

        private void pbRoad15_0_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 15,0 );
        }

        private void pbRoad4_1_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 4,1 );
        }

        private void pbRoad8_1_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 8,1 );
        }

        private void pbRoad12_1_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 12,1 );
        }

        private void pbRoad16_1_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 16,1 );
        }

        private void pbRoad3_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 3,2 );
        }

        private void pbRoad5_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 5,2 );
        }

        private void pbRoad7_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 7,2 );
        }

        private void pbRoad9_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 9,2 );
        }

        private void pbRoad11_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 11,2 );
        }

        private void pbRoad13_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 13,2 );
        }

        private void pbRoad15_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 15,2 );
        }

        private void pbRoad17_2_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 17,2 );
        }
        
        private void pbLandTile8_3_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 8, 3);
        }

        private void pbLandTile12_3_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 12, 3);
        }

        private void pbLandTile16_3_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 16, 3);
        }

        private void pbLandTile2_5_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 2, 5);
        }

        private void pbLandTile6_5_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 6, 5);
        }

        private void pbLandTile10_5_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 10, 5);
        }

        private void pbLandTile14_5_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 14, 5);
        }

        private void pbLandTile4_7_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 4, 7);
        }

        private void pbLandTile8_7_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 8, 7);
        }

        private void pbLandTile12_7_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 12, 7);
        }

        private void pbLandTile16_7_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 16, 7);
        }

        private void pbLandTile6_9_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 6, 9);
        }

        private void pbLandTile10_9_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 10, 9);
        }

        private void pbLandTile14_9_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Land", 14, 9);
        }

        private void pbSettle0_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 0, 6);
        }

        private void pbSettle4_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 4, 6);
        }

        private void pbSettle8_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 8, 6);
        }

        private void pbSettle12_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 12, 6);
        }

        private void pbSettle16_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 16, 6);
        }

        private void pbSettle20_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 20, 6);
        }

        private void pbSettle2_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement",2 ,6);
        }

        private void pbSettle6_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 6, 6);
        }

        private void pbSettle10_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 10, 6);
        }

        private void pbSettle14_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 14, 6);
        }

        private void pbSettle18_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 18, 6);
        }

        private void pbSettle2_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 2, 8);
        }

        private void pbSettle6_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement",6 ,8 );
        }

        private void pbSettle10_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 10, 8);
        }

        private void pbSettle14_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 14, 8);
        }

        private void pbSettle18_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 18, 8);
        }

        private void pbSettle4_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 4, 8);
        }

        private void pbSettle8_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 8, 8);
        }

        private void pbSettle12_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 12, 8);
        }

        private void pbSettle16_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 16, 8);
        }

        private void pbSettle4_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 4, 10);
        }

        private void pbSettle8_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 8, 10);
        }

        private void pbSettle12_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 12, 10);
        }

        private void pbSettle16_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 16, 10);
        }

        private void pbSettle6_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 6, 10);
        }

        private void pbSettle10_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 10, 10);
        }

        private void pbSettle14_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Settlement", 14, 10);
        }

        private void pbRoad2_3_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 2, 3);
        }

        private void pbRoad6_3_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 6, 3);
        }

        private void pbRoad10_3_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 10, 3);
        }

        private void pbRoad14_3_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 14, 3);
        }

        private void pbRoad18_3_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 18, 3);
        }

        private void pbRoad1_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 1, 4);
        }

        private void pbRoad3_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 3, 4);
        }

        private void pbRoad5_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 5, 4);
        }

        private void pbRoad7_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 7, 4);
        }

        private void pbRoad9_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road",9 ,4 );
        }

        private void pbRoad11_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 11, 4);
        }

        private void pbRoad13_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 13, 4);
        }

        private void pbRoad15_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 15, 4);
        }

        private void pbRoad17_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 17, 4);
        }

        private void pbRoad19_4_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 19, 4);
        }

        private void pbRoad0_5_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 0, 5);
        }

        private void pbRoad4_5_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 4, 5);
        }

        private void pbRoad8_5_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 8, 5);
        }

        private void pbRoad12_5_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 12, 5);
        }

        private void pbRoad16_5_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 16, 5);
        }

        private void pbRoad20_5_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 20, 5);
        }

        private void pbRoad1_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 1, 6);
        }

        private void pbRoad3_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 3, 6);
        }

        private void pbRoad5_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 5, 6);
        }

        private void pbRoad7_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 7, 6);
        }

        private void pbRoad9_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 9, 6);
        }

        private void pbRoad11_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 11, 6);
        }

        private void pbRoad13_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 13, 6);
        }

        private void pbRoad15_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 15, 6);
        }

        private void pbRoad17_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 17, 6);
        }

        private void pbRoad19_6_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 19, 6);
        }

        private void pbRoad2_7_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 2, 7);
        }

        private void pbRoad6_7_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 6, 7);
        }

        private void pbRoad10_7_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 10, 7);
        }

        private void pbRoad14_7_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 14, 7);
        }

        private void pbRoad18_7_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 18, 7);
        }

        private void pbRoad3_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 3, 8);
        }

        private void pbRoad5_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 5, 8);
        }

        private void pbRoad7_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 7, 8);
        }

        private void pbRoad9_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 9, 8);
        }

        private void pbRoad11_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 11, 8);
        }

        private void pbRoad13_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 13, 8);
        }

        private void pbRoad15_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 15, 8);
        }

        private void pbRoad17_8_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 17, 8);
        }

        private void pbRoad4_9_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 4, 9);
        }

        private void pbRoad8_9_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 8, 9);
        }

        private void pbRoad12_9_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 12, 9);
        }

        private void pbRoad16_9_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 16, 9);
        }

        private void pbRoad5_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 5, 10);
        }

        private void pbRoad7_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 7, 10);
        }

        private void pbRoad9_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 9, 10);
        }

        private void pbRoad11_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 11, 10);
        }

        private void pbRoad13_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 13, 10);
        }

        private void pbRoad15_10_Click(object sender, EventArgs e)
        {
            Game.State.ClickHandler("Road", 15, 10);
        }
        #endregion
    }




}
