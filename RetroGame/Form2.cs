using System.Text;
using System.Text.Json;
using RetroGame.Extensions;
using RetroGame.Models;

namespace RetroGame
{
    public partial class Form2 : Form
    {
        private readonly List<Tile> _tiles;
        private readonly GameSettings _settings;
        private readonly List<Tile> _mappedTiles = new List<Tile>();
        private readonly List<Player> _allPlayers = new List<Player>();
        private Player _currentPlayer;

        public Form2(GameSettings settings)
        {
            _settings = settings;
            var jsonContent = File.ReadAllText("Resources/Map/mapConfig.json", Encoding.UTF8);
            _tiles = JsonSerializer.Deserialize<List<Tile>>(jsonContent);

            InitializeComponent();
            LoadPlayerNames();
            lblNumero.Text = string.Empty;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!_settings.IsRandomMap)
            {
                DrawSequentialPanels();
            }
            else
            {
                DrawRandomPanels();
            }
        }

        private void LoadPlayerNames()
        {
            var numberOfPlayers = _settings.PlayerNames.Count();

            HidePlayers();

            for (var i = 1; i <= numberOfPlayers; i++)
            {
                var playerPicture = Controls.Find($"pictureBox{i}", true)[0] as PictureBox;
                var playerLabel = Controls.Find($"lblPlayerName{i}", true)[0] as Label;

                var player = new Player()
                {
                    Number = i,
                    Name = _settings.PlayerNames[i - 1]
                };
                _allPlayers.Add(player);

                playerLabel.Text = player.Name;
                playerPicture.Show();
                playerLabel.Show();

                var playerMapPicture = Controls.Find($"pic{i}pn{1}", true)[0] as PictureBox; 
                
                var toolTip = new ToolTip()
                {
                    IsBalloon = true,
                    ShowAlways = true,
                };
                toolTip.SetToolTip(playerMapPicture, player.Name);

                playerMapPicture.Show();
            }
            
            _currentPlayer = _allPlayers.First();
            lblCurrentPlayer.Text = _currentPlayer.Name;
        }

        private void HidePlayers()
        {
            for (var i = 1; i <= 8; i++)
            {
                var playerPicture = Controls.Find($"pictureBox{i}", true)[0] as PictureBox;
                var playerLabel = Controls.Find($"lblPlayerName{i}", true)[0] as Label;

                playerPicture.Hide();
                playerLabel.Hide();
            }

            for (var i = 1; i <= 16; i++)
            {
                for (var j = 1; j <= 8; j++)
                {
                    var playerMapPicture = Controls.Find($"pic{j}pn{i}", true)[0] as PictureBox;
                    playerMapPicture.Hide();
                }
            }
        }

        private void DrawSequentialPanels()
        {
            for (var i = 1; i <= 16; i++)
            {
                var panelName = "panel" + i;
                var panel = Controls.Find(panelName, true)[0] as Panel;

                if (panel == null || i > _tiles.Count) continue;

                panel.BackColor = ColorTranslator.FromHtml(_tiles[i - 1].Color);

                var label = new Label
                {
                    Text = _tiles[i - 1].Description,
                    ForeColor = Color.White,
                    Font = new Font(this.Font.FontFamily, 12, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };

                var toolTip = new ToolTip()
                {
                    IsBalloon = true,
                    ShowAlways = true,
                };

                toolTip.SetToolTip(label, _tiles[i - 1].Description);

                panel.Controls.Add(label);
                _mappedTiles.Add(_tiles[i - 1]);
            }
        }

        private void DrawRandomPanels()
        {
            var panels = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            panels.Shuffle();

            var panel1 = Controls.Find("panel1", true)[0] as Panel;
            if (panel1 != null)
            {
                panel1.BackColor = ColorTranslator.FromHtml(_tiles[0].Color);

                var label = new Label
                {
                    Text = _tiles[0].Description,
                    ForeColor = Color.White,
                    Font = new Font(this.Font.FontFamily, 12, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                panel1.Controls.Add(label);
                _mappedTiles.Add(_tiles[0]);
            }

            for (var i = 1; i < 16; i++)
            {
                _mappedTiles.Add(new Tile());
            }

            var counter = 1;
            foreach (var panelId in panels)
            {
                var panelName = "panel" + panelId;
                var panel = Controls.Find(panelName, true)[0] as Panel;

                if (panel == null) continue;

                panel.BackColor = ColorTranslator.FromHtml(_tiles[counter].Color);

                var label = new Label
                {
                    Text = _tiles[counter].Description,
                    ForeColor = Color.White,
                    Font = new Font(this.Font.FontFamily, 12, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                var toolTip = new ToolTip()
                {
                    IsBalloon = true,
                    ShowAlways = true,
                };

                toolTip.SetToolTip(label, _tiles[counter].Description);

                panel.Controls.Add(label);
                _mappedTiles[panelId - 1] = _tiles[counter];
                counter++;
            }
        }

        private void btRolarDado_Click(object sender, EventArgs e)
        {
            var rdn = new Random();
            var roll = rdn.Next(1, _settings.DiceMaxNumber + 1);
            lblNumero.Text = roll.ToString();
            
            _currentPlayer.Position += roll;

            if (_currentPlayer.Position <= 16)
            {
                var currentTile = _mappedTiles[_currentPlayer.Position - 1];

                var count = 0;
                while (currentTile.Action != 0)
                {
                    _currentPlayer.Position += currentTile.Action;
                    currentTile = _mappedTiles[_currentPlayer.Position - 1];
                    count++;

                    if (count > 2) break;
                }
            }

            if (_currentPlayer.Position > 16) 
                _currentPlayer.Finished = true;

            if (_currentPlayer.Position < 1)
                _currentPlayer.Position = 1;

            PrintPlayerMovement();

            btRolarDado.Enabled = false;
            btnProximo.Enabled = true;
        }
        
        private void btnProximo_Click(object sender, EventArgs e)
        {
            SetNextPlayer();
            btRolarDado.Enabled = true;
            btnProximo.Enabled = false;
        }

        private void SetNextPlayer()
        {
            var playingPlayers = _allPlayers.Where(i => !i.Finished).ToList();

            if (playingPlayers.Any() == false)
            {
                lblCurrentPlayer.Text = "Fim de jogo";
                btRolarDado.Enabled = false;
                btnProximo.Enabled = false;
                return;
            }

            _currentPlayer = _currentPlayer.Number != _allPlayers.Max(i=>i.Number) ?
                playingPlayers.First(i => i.Number > _currentPlayer.Number) :
                playingPlayers.First();

            lblCurrentPlayer.Text = _currentPlayer.Name;
            lblNumero.Text = string.Empty;
        }

        private void PrintPlayerMovement()
        {
            for (var i = 1; i <= 16; i++)
            {
                var playerMapPicture = Controls.Find($"pic{_currentPlayer.Number}pn{i}", true)[0] as PictureBox;

                if (i == _currentPlayer.Position)
                {
                    playerMapPicture.Show();
                }
                else
                {
                    playerMapPicture.Hide();
                }
            }
        }
    }
}
