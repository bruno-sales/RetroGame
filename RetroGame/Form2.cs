using System.Text;
using System.Text.Json;
using RetroGame.Extensions;
using RetroGame.Models;

namespace RetroGame
{
    public partial class Form2 : Form
    {
        private List<Tile> _tiles;
        private GameSettings _settings;

        public Form2(GameSettings settings)
        {
            _settings = settings;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var jsonContent = File.ReadAllText("Resources/Map/mapConfig.json", Encoding.UTF8);
            
            _tiles = JsonSerializer.Deserialize<List<Tile>>(jsonContent);

            if (!_settings.IsRandomMap)
            {
                DrawSequentialPanels();
            }
            else
            {
                DrawRandomPanels();
            }
        }

        private void DrawSequentialPanels()
        {
            for (var i = 1; i <= 16; i++)
            {
                var panelName = "panel" + i;
                var panel = Controls.Find(panelName, true)[0] as Panel;

                if (panel != null && i <= _tiles.Count)
                {
                    panel.BackColor = ColorTranslator.FromHtml(_tiles[i-1].Color);
                    
                    var label = new Label
                    {
                        Text = _tiles[i - 1].Description,
                        ForeColor = Color.White,
                        Font = new Font(this.Font.FontFamily,12, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    };
                    
                    panel.Controls.Add(label);
                }
            }
        }

        private void DrawRandomPanels()
        {
            var panels = new List<int>(){2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
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
            }

            var counter = 1;
            foreach (var panelId in panels)
            {
                var panelName = "panel" + panelId;
                var panel = Controls.Find(panelName, true)[0] as Panel;

                if (panel != null)
                {
                    panel.BackColor = ColorTranslator.FromHtml(_tiles[counter].Color);

                    var label = new Label
                    {
                        Text = _tiles[counter].Description,
                        ForeColor = Color.White,
                        Font = new Font(this.Font.FontFamily, 12, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    };

                    panel.Controls.Add(label);
                    counter++;
                }
            }
        }


    }
}
