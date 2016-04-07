# Benchmark on how fast arrays casted to IList works




##Results
Was tested on Win10, Intel i7@920  2.67GHz
### Debug build

```
Benchmark                             Mean Mean-Error   Sdev  Unit
CachedSize  : Generic : Array      142,302     31,049 20,537 ms/op
CachedSize  : Generic : List       123,588     40,522 26,803 ms/op
CachedSize  : NonGen  : Array      140,076     37,693 24,931 ms/op
CachedSize  : NonGen  : List       147,987     31,055 20,541 ms/op
CachedSize  : Exact   : Array       65,334     15,498 10,251 ms/op
CachedSize  : Exact   : List       128,963     20,326 13,444 ms/op
InlineCount : Generic : Array      182,993     47,801 31,617 ms/op
InlineCount : Generic : List       185,356     37,980 25,121 ms/op
InlineCount : NonGen  : Array      175,120     29,301 19,380 ms/op
InlineCount : NonGen  : List       170,942     29,498 19,511 ms/op
InlineCount : Exact   : Array       62,975     24,662 16,312 ms/op
InlineCount : Exact   : List       136,844     32,367 21,409 ms/op
Foreach     : Generic : Array      175,576     41,798 27,647 ms/op
Foreach     : Generic : List       179,927     33,865 22,400 ms/op
Foreach     : NonGen  : Array      188,033     33,629 22,243 ms/op
Foreach     : NonGen  : List       185,420     41,662 27,557 ms/op
Foreach     : Exact   : Array       72,043     15,672 10,366 ms/op
Foreach     : Exact   : List       115,024     29,015 19,192 ms/op
Linq        : Generic : Array      160,069     37,853 25,037 ms/op
Linq        : Generic : List       147,109     29,588 19,571 ms/op
Linq        : NonGen  : Array      148,716     31,998 21,165 ms/op
Linq        : NonGen  : List       161,140     53,432 35,342 ms/op
Linq        : Exact   : Array      144,677     40,629 26,873 ms/op
Linq        : Exact   : List       164,881     33,954 22,458 ms/op
```

### Release build

```
Benchmark                             Mean Mean-Error   Sdev  Unit
CachedSize  : Generic : Array       73,224     26,604 17,597 ms/op
CachedSize  : Generic : List        62,275      9,980  6,601 ms/op
CachedSize  : NonGen  : Array       72,289     18,936 12,525 ms/op
CachedSize  : NonGen  : List        73,150     22,744 15,044 ms/op
CachedSize  : Exact   : Array       11,482      1,616  1,069 ms/op
CachedSize  : Exact   : List        29,275      8,963  5,928 ms/op
InlineCount : Generic : Array      110,840     19,507 12,902 ms/op
InlineCount : Generic : List       119,872     39,026 25,814 ms/op
InlineCount : NonGen  : Array      108,968     32,408 21,436 ms/op
InlineCount : NonGen  : List       125,409     33,665 22,268 ms/op
InlineCount : Exact   : Array       10,721      1,230  0,814 ms/op
InlineCount : Exact   : List        22,129      3,501  2,315 ms/op
Foreach     : Generic : Array      146,495     27,239 18,017 ms/op
Foreach     : Generic : List       141,909     38,537 25,490 ms/op
Foreach     : NonGen  : Array      138,296     43,884 29,027 ms/op
Foreach     : NonGen  : List       141,992     34,901 23,085 ms/op
Foreach     : Exact   : Array       10,188      2,143  1,417 ms/op
Foreach     : Exact   : List        72,159     22,669 14,994 ms/op
Linq        : Generic : Array      149,554     30,003 19,845 ms/op
Linq        : Generic : List       135,827     29,315 19,390 ms/op
Linq        : NonGen  : Array      143,484     43,579 28,825 ms/op
Linq        : NonGen  : List       151,072     32,893 21,757 ms/op
Linq        : Exact   : Array      150,130     37,271 24,652 ms/op
Linq        : Exact   : List       181,945     32,370 21,411 ms/op
```
