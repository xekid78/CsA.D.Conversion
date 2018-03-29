# CsA.D.Conversion
西暦から和暦を割り出す（.NET Core）

## 処理
昭和元年から10年までの西暦和暦変換を行います

## コード
```
using System;

namespace Ccalconv
{
    class Ccalconv
    {
        static void Main(string[] args)
        {
            for (int seireki = 1926; seireki <= 1935; seireki++)
            {
                Console.Write("西暦" + seireki + "年は");
                int syowa = seireki - 1925;
                Console.WriteLine("昭和" + syowa + "年です");
            }
        }
    }
}
```

## 出力結果  
```
西暦1926年は昭和1年です
西暦1927年は昭和2年です
西暦1928年は昭和3年です
西暦1929年は昭和4年です
西暦1930年は昭和5年です
西暦1931年は昭和6年です
西暦1932年は昭和7年です
西暦1933年は昭和8年です
西暦1934年は昭和9年です
西暦1935年は昭和10年です
```
  
## 開発環境
| 開発ツール |  |
|:-|:-|
| OS | Windows10 |
| 統合開発環境(IDE) | Visual Studio Community 2017 |
| 開発言語 | Visual C# |
