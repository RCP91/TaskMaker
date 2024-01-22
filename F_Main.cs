using System.Text.RegularExpressions;

namespace TaskMaker
{
    public partial class F_Main : Form
    {
        string MonsterName;
        int Exp;
        int Amount;
        int Money;
        int Quest;
        int Storage;
        bool onlyItem;
        List<(string? Name, int TypeID)> nameTypePairs = new List<(string, int)>();
        readonly string localfile = AppDomain.CurrentDomain.BaseDirectory;

        public F_Main()
        {
            InitializeComponent();
            lb_info.Visible = false;
            btn_create.Visible = false;

            GetItemsList(localfile + "items.srv");

            bool exists = System.IO.Directory.Exists(localfile + "build");
            if (!exists)
                System.IO.Directory.CreateDirectory(localfile + "build");
        }
        private void txtlabel()
        {
            lb_info.Visible = true;
            string? selectedConatiner = "";
            string? itens = "";
            string? selectedItem = "";

            int containeID = 0;
            int itensID = 0;

            if (cb_container.Text.Length > 1 || cb_items.Text.Length > 1)
            {
                if (cb_items.Text.Length > 1)
                {
                    selectedItem = cb_items.Text;
                    var selectedItemInfo = nameTypePairs.FirstOrDefault(pair => pair.Name == selectedItem);
                    itensID = selectedItemInfo.TypeID;
                }
                if (cb_container.Text.Length > 1)
                {
                    selectedConatiner = cb_container.Text;
                    var selectedItemInfo = nameTypePairs.FirstOrDefault(pair => pair.Name == selectedConatiner);
                    containeID = selectedItemInfo.TypeID;
                }
            }
            if (Exp > 0 && Money > 0)
            {
                if (itensID > 0)
                {
                    lb_info.Text = $"Monster: {MonsterName} - Storage: {Storage} - Quest: {Quest}\nKills: {Amount} - Exp: {Exp} - Money: {Money}\n"
                    + $"Item: {nud_items.Value} -> {selectedItem} | ID: {itensID}\nContainer: {nud_container.Value} -> {selectedConatiner} | ID: {containeID}";
                }
                else
                {
                    lb_info.Text = $"Monster: {MonsterName} - Storage: {Storage} - Quest: {Quest}\nKills: {Amount}\nExp: {Exp}\nMoney: {Money}";
                }
            }
            else if (Exp > 0)
            {
                if (itensID > 0)
                {
                    lb_info.Text = $"Monster: {MonsterName} - Storage: {Storage} - Quest: {Quest}\nKills: {Amount} - Exp: {Exp}\n"
                        + $"Item: {nud_items.Value} -> {selectedItem} | ID: {itensID}\nContainer: {nud_container.Value} -> {selectedConatiner} | ID: {containeID}";
                }
                else
                {
                    lb_info.Text = $"Monster: {MonsterName} - Storage: {Storage} - Quest: {Quest}\nKills: {Amount}\nExp: {Exp}";
                }
            }
            else if (Money > 0)
            {
                if (itensID > 0)
                {
                    lb_info.Text = $"Monster: {MonsterName} - Storage: {Storage} - Quest: {Quest}\nKills: {Amount} - Money: {Money}\n"
                    + $"Item: {nud_items.Value} -> {selectedItem} | ID: {itensID}\nContainer: {nud_container.Value} -> {selectedConatiner} | ID: {containeID}";
                }
                else
                {
                    lb_info.Text = $"Monster: {MonsterName} - Storage: {Storage} - Quest: {Quest}\nKills: {Amount}\nMoney: {Money}";
                }
            }
            else if (onlyItem)
            {
                lb_info.Text = $"Monster: {MonsterName} - Storage: {Storage} - Quest: {Quest}\nKills: {Amount}\n"
                    + $"Item: {nud_items.Value} -> {selectedItem} | ID: {itensID}\nContainer: {nud_container.Value} -> {selectedConatiner} | ID: {containeID}";
            }
            btn_create.Visible = true;
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            MakeToNpc(MonsterName, Amount, Exp, Money);
            lb_info.Visible = false;
            btn_create.Visible = false;
            nud_storage.Value += 1;
            nud_quest.Value += 1;
        }
        private void btn_exp_Click(object sender, EventArgs e)
        {
            MonsterName = tb_name.Text;
            Amount = (int)nud_amount.Value;
            Exp = (Amount * (int)nud_exp.Value) * (int)nud_percentExp.Value / 100;
            Money = 0;
            Storage = (int)nud_storage.Value;
            Quest = (int)nud_quest.Value;
            txtlabel();
        }
        private void btn_exp_money_Click(object sender, EventArgs e)
        {

            MonsterName = tb_name.Text;
            Amount = (int)nud_amount.Value;
            Exp = (Amount * (int)nud_exp.Value) * (int)nud_percentExp.Value / 100;
            Money = (Amount * (int)nud_exp.Value) * (int)nud_percentMoney.Value / 100;
            Storage = (int)nud_storage.Value;
            Quest = (int)nud_quest.Value;
            txtlabel();

        }
        private void btn_money_Click(object sender, EventArgs e)
        {
            MonsterName = tb_name.Text;
            Amount = (int)nud_amount.Value;
            Exp = 0;
            Money = (Amount * (int)nud_exp.Value) * (int)nud_percentMoney.Value / 100;
            Storage = (int)nud_storage.Value;
            Quest = (int)nud_quest.Value;
            txtlabel();
        }
        private void btn_items_Click(object sender, EventArgs e)
        {
            MonsterName = tb_name.Text;
            Amount = (int)nud_amount.Value;
            Exp = 0;
            Money = 0;
            Storage = (int)nud_storage.Value;
            Quest = (int)nud_quest.Value;
            onlyItem = true;
            txtlabel();
        }

        private void MakeToNpc(string name, int amount, int exp, int money)
        {
            string newLuaContent = $"\t[\"{name}\"] = {{count = {amount}, storage = {Storage}, start = 1, plural = \"{name}s\"}},";
            string? containers = "";
            string? itens = "";
            string? item_diag = "";
            string? container_diag = "";
            int r = (int)nud_repeat.Value;

            string diag_money_exp = "";
            string diag_exp = "";
            string diag_money = "";

            string Voc = "";
            string vocInfo = "";
            string lvlMin = "";
            string lvlMax = "";
            string lvlInfo = "";

            string[] nameE = name.Split(' ');
            string nameEx = "";

            if (nameE.Count() > 1)
            {
                nameEx = nameE[0] + "\",\"" + nameE[1];
            }
            else
            {
                nameEx = name;
            }

            if (cb_sorcerer.Checked)
            {
                Voc += "Sorcerer,";
            }
            if (cb_druid.Checked)
            {
                Voc += "Druid,";
            }
            if (cb_paladin.Checked)
            {
                Voc += "Paladin,";
            }
            if (cb_knight.Checked)
            {
                Voc += "Knight,";
            }
            if (!string.IsNullOrEmpty(Voc))
            {
                vocInfo = "\n";
                if (nud_lvlMin.Value > 0)
                {
                    vocInfo += $"Level>={nud_lvlMin.Value},";
                }
                if (nud_lvlMax.Value > 0)
                {
                    vocInfo += $"Level<={nud_lvlMax.Value},";
                }

                string VocThis = Voc.TrimEnd(',');
                string[] vocInfo2 = VocThis.Split(',');
                if (vocInfo2.Length == 1)
                {
                    vocInfo += $"\"{nameEx}\" -> \"This task only for {VocThis.ToLower()}...\"";
                }
                else
                {
                    vocInfo += $"\"{nameEx}\" -> \"This task only for {string.Join(", ", vocInfo2.Take(vocInfo2.Length - 1)).ToLower()} and {vocInfo2.Last().ToLower()}...\"";
                }
            }

            if (nud_lvlMin.Value > 0 || nud_lvlMax.Value > 0)
            {
                lvlInfo = $"\n{Voc}\"{nameEx}\" -> \"This task only for ";
            }
            if (nud_lvlMin.Value > 0)
            {
                lvlMin = $"Level>={nud_lvlMin.Value},";
                if (nud_lvlMax.Value > 0)
                {
                    lvlMax = $"Level<={nud_lvlMax.Value},";
                    lvlInfo += $"level {nud_lvlMin.Value} to {nud_lvlMax.Value}...\"";
                }
                else
                {
                    lvlInfo += $"level {nud_lvlMin.Value} above...\"";
                }
            }
            if (nud_lvlMax.Value > 0 && nud_lvlMin.Value == 0)
            {
                lvlMax = $"Level<={nud_lvlMax.Value},";
                lvlInfo += $"level {nud_lvlMax.Value} below...\"";
            }

            string selectedItem = cb_items.Text;
            int containeID = 0;
            int itensID = 0;


            using (StreamWriter luaWriter = new StreamWriter("build/tasks.lua", append: true))
            {
                luaWriter.WriteLine(newLuaContent);
            }
            if (cb_items.Text.Length > 1)
            {
                var ItemList = nameTypePairs.FirstOrDefault(pair => pair.Name == selectedItem);
                itensID = ItemList.TypeID;

                if (cb_container.Text.Length > 1)
                {
                    var selectedItemInfo = nameTypePairs.FirstOrDefault(pair => pair.Name == cb_container.Text);
                    containeID = selectedItemInfo.TypeID;
                }
                if (containeID > 0)
                {
                    container_diag = $"{nud_container.Value} {cb_container.Text.Replace('_', ' ').ToLower()} with {nud_items.Value} {selectedItem}";
                    containers = $", Amount={nud_container.Value}, CreateContainer({containeID},{itensID},{nud_items.Value})";
                }
                if (itensID > 0 && containeID == 0)
                {
                    item_diag = $"{nud_items.Value} {selectedItem}";
                    itens = $", Amount={nud_items.Value}, Create({itensID})";
                }
            }

            string Content = "";
            if (Exp > 0 && Money > 0)
            {
                if (itensID > 0)
                {
                    diag_money_exp = $"{container_diag}{item_diag}, {Exp} experience and {Money} gold";
                }
                else
                {
                    diag_money_exp = $"{Exp} experience and {Money} gold";
                }
                Content =
                $"# ----------- TASKS NPC TAKE-------------\nQuestValue({Quest})>={r},\"{nameEx}\" -> \"You have already done this task {r} times. Ask for a different one.\"\n{Voc}{lvlMin}{lvlMax}\"{nameEx}\" -> \"If you kill {amount} {name} for me I will give you {diag_money_exp}. accept?\", Topic=1, Data={Storage}{vocInfo}{lvlInfo}\n" +
                $"# ----------- QUEST -------------\n" +
                $"SetQuestValue({Storage}, 0),\n\n" +
                $"# ----------- TASKS NPC REWARD -------------\n" +
                $"\"reward\",QuestValue({Storage})>={Amount} -> \"Thank you! Here's your reward.\"{containers}{itens}, Amount={Exp}, Experience(Amount), Price={Money}, CreateMoney, SetQuestValue(999, 0), SetQuestValue({Storage}, 0), SetQuestValue({Quest}, QuestValue({Quest})+1)\n" +
                $"\"reward\",QuestValue({Storage})>=1,QuestValue({Storage})<{Amount} -> \"You have to kill {Amount} {name}. Come back later.\", Idle\n" +
                $"============================================================\n";

            }
            else if (Exp > 0)
            {
                if (itensID > 0)
                {
                    diag_exp = $"{container_diag}{item_diag} and {Exp} experience";
                }
                else
                {
                    diag_exp = $"{Exp} experience";
                }
                Content =
                $"# ----------- TASKS NPC TAKE-------------\nQuestValue({Quest})>={r},\"{nameEx}\" -> \"You have already done this task {r} times. Ask for a different one.\"\n{Voc}{lvlMin}{lvlMax}\"{nameEx}\" -> \"If you kill {amount} {name} for me I will give you {diag_exp}. accept?\", Topic=1, Data={Storage}{vocInfo}{lvlInfo}\n" +
                $"# ----------- QUEST -------------\n" +
                $"SetQuestValue({Storage}, 0),\n\n" +
                $"# ----------- TASKS NPC REWARD -------------\n" +
                $"\"reward\",QuestValue({Storage})>={Amount} -> \"Thank you! Here's your reward.\"{containers}{itens}, Amount={Exp}, Experience(Amount), SetQuestValue(999, 0), SetQuestValue({Storage}, 0), SetQuestValue({Quest}, QuestValue({Quest})+1)\n" +
                $"\"reward\",QuestValue({Storage})>=1,QuestValue({Storage})<{Amount} -> \"You have to kill {Amount} {name}. Come back later.\", Idle\n\n" +
                $"============================================================\n";
            }
            else if (Money > 0)
            {
                if (itensID > 0)
                {
                    diag_money = $"{container_diag}{item_diag} and {Money} gold";
                }
                else
                {
                    diag_money = $"{Money} gold";
                }
                Content =
                $"# ----------- TASKS NPC TAKE-------------\nQuestValue({Quest})>= {r} ,\"{nameEx}\" -> \"You have already done this task {r} times. Ask for a different one.\"\n{Voc}{lvlMin}{lvlMax}\"{nameEx}\" -> \"If you kill {amount} {name} for me I will give you {diag_money}. accept?\", Topic=1, Data={Storage}{vocInfo}{lvlInfo}\n" +
                $"# ----------- QUEST -------------\n" +
                $"SetQuestValue({Storage}, 0),\n\n" +
                $"# ----------- TASKS NPC REWARD -------------\n" +
                $"\"reward\",QuestValue({Storage})>={Amount} -> \"Thank you! Here's your reward.\"{containers}{itens}, Price={Money}, CreateMoney, SetQuestValue(999, 0), SetQuestValue({Storage}, 0), SetQuestValue({Quest}, QuestValue({Quest})+1)\n" +
                $"\"reward\",QuestValue({Storage})>=1,QuestValue({Storage})<{Amount} -> \"You have to kill {Amount} {name}. Come back later.\", Idle\n\n" +
                $"============================================================\n";
            }
            else if (onlyItem)
            {
                Content =
                $"# ----------- TASKS NPC TAKE-------------\nQuestValue({Quest})>={r},\"{nameEx}\" -> \"You have already done this task {r} times. Ask for a different one.\"\n{Voc}{lvlMin}{lvlMax}\"{nameEx}\" -> \"If you kill {amount} {name} for me I will give you {container_diag}{item_diag}. accept?\", Topic=1, Data={Storage}{vocInfo}{lvlInfo}\n" +
                $"# ----------- QUEST -------------\n" +
                $"SetQuestValue({Storage}, 0),\n\n" +
                $"# ----------- TASKS NPC REWARD -------------\n" +
                $"\"reward\",QuestValue({Storage})>={Amount} -> \"Thank you! Here's your reward.\"{containers}{itens}, SetQuestValue(999, 0), SetQuestValue({Storage}, 0), SetQuestValue({Quest}, QuestValue({Quest})+1)\n" +
                $"\"reward\",QuestValue({Storage})>=1,QuestValue({Storage})<{Amount} -> \"You have to kill {Amount} {name}. Come back later.\", Idle\n\n" +
                $"============================================================\n";
            }

            using (StreamWriter unknownWriter = new StreamWriter("build/task.ndb", append: true))
            {
                unknownWriter.WriteLine(Content);
            }
            if (Money > 0)
            {
                itensID = 3031;
            }
            string NameGif = string.Join("", name.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)));
            string PhpContent = $"<tr style=\"height: 18px; text-align: center;\">\r\n<td style=\"width: 32%; height: 18px;\">\r\n<p><a title=\"{name}\" href=\"/?subtopic=creatures&amp;creature={name.Replace(' ', '+').ToLower()}\"><img style=\"display: block; margin-left: auto; margin-right: auto;\" src=\"/images/monsters/{NameGif.ToLower()}.gif\" width=\"32\" height=\"32\"></a></p>\r\n</td>\r\n<td style=\"width: 8%; height: 18px; text-align: center;\">{Amount}</td>\r\n<td style=\"width: 48%; height: 18px;\">&nbsp;<img src=\"/images/items/{itensID}.gif\" alt=\"\" width=\"32\" height=\"32\">{diag_money}{diag_exp}{diag_money_exp}{container_diag}</td>\r\n<td style=\"width: 18%; height: 18px;\">&nbsp;{exp}</td>\r\n</tr>";
            using (StreamWriter luaWriter = new StreamWriter("build/tasks-table.php", append: true))
            {
                luaWriter.WriteLine(PhpContent);
            }
            onlyItem = false;
        }
        private void GetItemsList(string filePath)
        {
            if (File.Exists(filePath))
            {
                string currentName = string.Empty;
                int currentTypeID = 0;
                string[] lines = File.ReadAllLines(filePath);
                bool found = false;

                foreach (string line in lines)
                {
                    if (line.Contains("Name"))
                    {
                        Match match = Regex.Match(line, "\"(.*?)\"");
                        if (match.Success)
                        {
                            currentName = match.Groups[1].Value;
                        }
                    }
                    else if (line.Contains("TypeID"))
                    {
                        Match match = Regex.Match(line, @"\d+");
                        if (match.Success)
                        {
                            int.TryParse(match.Value, out currentTypeID);
                        }
                    }
                    else if (line.Contains("ring")
                        || line.Contains("feet")
                        || line.Contains("Rune")
                        || line.Contains("Cumulative")
                        || line.Contains("FluidContainer")
                        || line.Contains("Shield")
                        || line.Contains("Weapon")
                        || line.Contains("Armor")
                        || line.Contains("backpack"))
                        found = true;

                    if (line.Contains("SlotType=backpack") && found)
                    {
                        cb_container.Items.Add(RemoveArticle(currentName));
                    }
                    else if (string.IsNullOrWhiteSpace(line))
                    {
                        if (found)
                        {
                            nameTypePairs.Add((RemoveArticle(currentName), currentTypeID));
                        }
                        currentName = string.Empty;
                        currentTypeID = 0;
                        found = false;
                    }
                }

                if (nameTypePairs.Count > 0)
                {
                    foreach (var pair in nameTypePairs)
                    {
                        cb_items.Items.Add(pair.Name);
                    }
                }
                else
                {
                    msg("Nothing found items.");
                }
            }
            else
            {
                msg($"Local file: {filePath} not load.");
            }
        }
        private string RemoveArticle(string input)
        {
            string[] articles = { "a ", "an " };

            foreach (string article in articles)
            {
                if (input.StartsWith(article, StringComparison.OrdinalIgnoreCase))
                {
                    return input.Substring(article.Length).TrimStart();
                }
            }
            return input;
        }
        private void msg(string t, params object[] f)
        {
            MessageBox.Show(string.Format(t, f), "Ops!");
        }
    }
}