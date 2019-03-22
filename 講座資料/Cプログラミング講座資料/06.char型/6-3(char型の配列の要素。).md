```
#include<stdio.h>

int main(){
	
	char str[20]="Hello World!";
	
	printf("%s\n",str);
	printf("%c\n",str[4]);
	printf("%c\n",str[10]);
	
	return 0;
}
```
#### 解説

前回と同様に,char型の配列によって、文字列をstrに入れている。  
そして今回は実際に配列にどのようになっているか確かめた。
```
str[4]=o,str[10]=d
```
であることが、実行結果よりわかっただろうが、  
これはstr[0]=H  str[1]=e str[2]=l  str[3]=l str[4]=o  
のように、文字列の先頭から順々に配列に代入しているのである。C言語ではこのように文字列を取り扱っていく。