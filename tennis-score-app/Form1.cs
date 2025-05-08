using System.Numerics;
using static System.Windows.Forms.ListViewItem;

namespace tennis_score_app
{
    public partial class Form1 : Form
    {
        private static Dictionary<string, int> players = new()
        {
            { "R. Federer", 4 },
            { "G. Dimitrov", 5 },
            { "R. Nadal", 5 }
        };

        private static Dictionary<(string, int), List<(string, int)>> games = new()
            {
                { ("G. Dimitrov", 3), new List<(string, int)>{("R. Nadal", 2)} },
                { ("R. Nadal", 3), new List<(string, int)>{("R. Federer", 1)} },
                { ("G. Dimitrov", 2), new List<(string, int)>{("R. Federer", 3)} }
            };

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem selectedRow = listView1.SelectedItems[0];
            ListViewSubItem playerNameCell = selectedRow.SubItems[0];
            string playerName = playerNameCell.Text;

            using (PlayerInfoForm playerInfoForm = new PlayerInfoForm(playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }

        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames(string playerName)
            => games.Where(x => x.Key.Item1 == playerName
            || x.Value.Any(y => y.Item1 == playerName)).ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName
            || x.Key.Item1 == playerName).ToList());

        private void Form1_Load(object sender, EventArgs e)
        {
            FillRankingListView();
            FillInLatestGamesListView();
        }

        private void FillRankingListView()
        {
            listView1.Items.Clear();

            foreach (var player in players.OrderByDescending(g => g.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();

                ListViewItem rollInRankingListView = new();

                rollInRankingListView.SubItems[0].Text = playerName;
                rollInRankingListView.SubItems.Add(playerPoints);

                listView1.Items.Add(rollInRankingListView);
            }
        }

        public void FillInLatestGamesListView()
        {
            this.listView2.Items.Clear();

            foreach (var game in games.Reverse())
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }

        public void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem rollInLatestGamesListView = new();

            rollInLatestGamesListView.SubItems[0].Text = firstPlayer.Item1;
            rollInLatestGamesListView.SubItems.Add(secondPlayer.Item1);
            rollInLatestGamesListView.SubItems.Add(winner);
            rollInLatestGamesListView.SubItems.Add($"{firstPlayer.Item2} - {secondPlayer.Item2}");

            listView2.Items.Add(rollInLatestGamesListView);
        }

        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item2 < secondPlayer.Item2)
            {
                return secondPlayer.Item1;
            }
            else if (firstPlayer.Item2 > secondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }
            else
            {
                return "Draw";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGameForm newGameForm = new NewGameForm();
            if (newGameForm.ShowDialog() == DialogResult.OK)
            {
                AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
            }
        }

        public void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGamesData(firstPlayer, secondPlayer);

            FillPlayerWithPoints(firstPlayer);
            FillPlayerWithPoints(secondPlayer);

            FillRankingListView();
            FillInLatestGamesListView();
        }

        public void FillGamesData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (games.ContainsKey(firstPlayer))
            {
                games[firstPlayer].Add(secondPlayer);
            }
            else if (games.ContainsKey(secondPlayer))
            {
                games[secondPlayer].Add(firstPlayer);
            }
            else
            {
                games.Add(firstPlayer, new List<(string, int)> { secondPlayer });
            }
        }

        public void FillPlayerWithPoints((string, int) player)
        {
            if (players.ContainsKey(player.Item1))
            {
                players[player.Item1] += player.Item2;
            }
            else
            {
                players.Add(player.Item1, player.Item2);
            }
        }
    }
}
