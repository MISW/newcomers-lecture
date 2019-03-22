```
#include<stdio.h>

int function(int x){
	
	return x*x;
	
}

int main(){
	
	int a = function(3);
	int b = function(10);
	
	printf("%d %d\n",a,b);
	
	return 0;
}
```
#### 以下解説
```
int function(int x){
	
	return x*x;
	
}
```

今まで関数を作る時はvoidで作り、命令をまとめていましたが、今回はint型で関数を作り、括弧の中身にint xというものがあります。これを引数といい、この後で受取る数によって関数の挙動が変わります。  
そして、return x*x;  
これの意味はfunction()自身が数になる、みたいな感じで、例えばfunction(4)とした場合、
int x = 4とその関数の時点でなり、  
return x*x;  
つまり4*4 = 16が返ってくる。  
なのでfunction(4)==16ということになります。  
そのことをmain関数にて実行してるので、確かめてみてください。