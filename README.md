# Benchmark on how fast arrays casted to IList works




##Results
Was tested on Win10, Intel i7@920  2.67GHz
### Debug build

```
Benchmark                             Mean Mean-Error   Sdev  Unit
CachedSize  : Generic : Array      115,749     28,383 18,774 ms/op
CachedSize  : Generic : List       129,065     54,537 36,073 ms/op
CachedSize  : NonGen  : Array      113,076     27,718 18,334 ms/op
CachedSize  : NonGen  : List       125,899     38,820 25,677 ms/op
CachedSize  : Exact   : Array       52,585     18,567 12,281 ms/op
CachedSize  : Exact   : List        96,507     21,722 14,368 ms/op
InlineCount : Generic : Array      181,577     52,626 34,809 ms/op
InlineCount : Generic : List       165,103     63,292 41,864 ms/op
InlineCount : NonGen  : Array      178,241     48,935 32,367 ms/op
InlineCount : NonGen  : List       141,328     27,803 18,390 ms/op
InlineCount : Exact   : Array       69,939     17,788 11,766 ms/op
InlineCount : Exact   : List       145,089     33,436 22,116 ms/op
Foreach     : Generic : Array      174,946     21,641 14,314 ms/op
Foreach     : Generic : List       164,431     39,183 25,917 ms/op
Foreach     : NonGen  : Array      162,944     25,630 16,953 ms/op
Foreach     : NonGen  : List       177,660     51,715 34,206 ms/op
Foreach     : Exact   : Array       66,591     26,078 17,249 ms/op
Foreach     : Exact   : List       152,177     33,068 21,873 ms/op
Linq        : Generic : Array      151,177     40,527 26,806 ms/op
Linq        : Generic : List       160,643     44,488 29,426 ms/op
Linq        : NonGen  : Array      166,014     23,520 15,557 ms/op
Linq        : NonGen  : List       133,809     30,516 20,184 ms/op
Linq        : Exact   : Array      136,752     38,692 25,592 ms/op
Linq        : Exact   : List       139,918     35,991 23,806 ms/op
```

### Release build

```
Benchmark                             Mean Mean-Error   Sdev  Unit
CachedSize  : Generic : Array      115,749     28,383 18,774 ms/op
CachedSize  : Generic : List       129,065     54,537 36,073 ms/op
CachedSize  : NonGen  : Array      113,076     27,718 18,334 ms/op
CachedSize  : NonGen  : List       125,899     38,820 25,677 ms/op
CachedSize  : Exact   : Array       52,585     18,567 12,281 ms/op
CachedSize  : Exact   : List        96,507     21,722 14,368 ms/op
InlineCount : Generic : Array      181,577     52,626 34,809 ms/op
InlineCount : Generic : List       165,103     63,292 41,864 ms/op
InlineCount : NonGen  : Array      178,241     48,935 32,367 ms/op
InlineCount : NonGen  : List       141,328     27,803 18,390 ms/op
InlineCount : Exact   : Array       69,939     17,788 11,766 ms/op
InlineCount : Exact   : List       145,089     33,436 22,116 ms/op
Foreach     : Generic : Array      174,946     21,641 14,314 ms/op
Foreach     : Generic : List       164,431     39,183 25,917 ms/op
Foreach     : NonGen  : Array      162,944     25,630 16,953 ms/op
Foreach     : NonGen  : List       177,660     51,715 34,206 ms/op
Foreach     : Exact   : Array       66,591     26,078 17,249 ms/op
Foreach     : Exact   : List       152,177     33,068 21,873 ms/op
Linq        : Generic : Array      151,177     40,527 26,806 ms/op
Linq        : Generic : List       160,643     44,488 29,426 ms/op
Linq        : NonGen  : Array      166,014     23,520 15,557 ms/op
Linq        : NonGen  : List       133,809     30,516 20,184 ms/op
Linq        : Exact   : Array      136,752     38,692 25,592 ms/op
Linq        : Exact   : List       139,918     35,991 23,806 ms/op
```