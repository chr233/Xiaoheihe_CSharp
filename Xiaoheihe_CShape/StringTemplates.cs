namespace Xiaoheihe_CShape
{
    internal static class StringTemplates
    {
        internal static readonly string[] Emojis = {
            "[cube_闭嘴]",
            "[cube_并不简单]",
            "[cube_沧桑]",
            "[cube_打脸]",
            "[cube_感动]",
            "[cube_咕咕]",
            "[cube_乖]",
            "[cube_汗]",
            "[cube_黑人问号]",
            "[cube_滑稽]",
            "[cube_加油]",
            "[cube_惊讶]",
            "[cube_开心]",
            "[cube_哭泣]",
            "[cube_酷]",
            "[cube_困]",
            "[cube_怒]",
            "[cube_喷水]",
            "[cube_凄凉]",
            "[cube_生气]",
            "[cube_睡觉]",
            "[cube_摊手]",
            "[cube_叹气]",
            "[cube_吐]",
            "[cube_哇]",
            "[cube_微笑]",
            "[cube_委屈]",
            "[cube_捂脸哭]",
            "[cube_喜欢]",
            "[cube_吓]",
            "[cube_笑cry]",
            "[cube_学习]",
            "[cube_晕]",
            "[cube_赞]",
            "[cube_doge]",
            "[cube_H币]"
        };

        internal static readonly string[] Words =
        {
            "zsbd",
            "冲冲冲",
            "试试先试试先",
            "经验+3",
            "拉低中奖率",
            "嗨害嗨"
        };

        internal static string RandomEmoji()
        {
            Random random = new();
            return Emojis[random.Next(Emojis.Length)];
        }

        internal static string RandomWord()
        {
            Random random = new();
            return Words[random.Next(Words.Length)];
        }
    }
}
