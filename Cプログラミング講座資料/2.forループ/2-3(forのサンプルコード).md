#### Hello Worldを10回表示する
```
#include<stdio.h>

int main(){

	int i;
	
	for(i=0;i<10;i++){
		printf("Hello World\n");
	}
	
	return 0;
}
```
今回のように for(i=0;i<繰り返したい数;i++)  
を使用するとうまくいきます。  

#### 縦に 0 1 2 3 4 5 6 7 8 9と表示させるプログラム
```
#include<stdio.h>

int main(){
	
	int i;
	
	for(i=0;i<10;i++){
		printf("%d\n",i);
	}
	
	return 0;
}
```

forはfor(i=始めたい数;i<ここまで行ったら実行しない数;i++)  
のように組むことも多いです。

#### 1から6までを縦に表示して、その後6から1を縦に表示する
```
#include<stdio.h>

int main(){
	int i;
	
	for(i=1;i<=6;i++){
		printf("%d\n",i);
	}

	/*
	今回継続条件に <= というものを使っていますがこれは≦と同じ意味です。
	つまりi=6の時でも条件をみたすのでループを続行することになります。
	*/
	
	printf("\n");
	//\nだけで改行のみってこともできます。

	for(i=6;i>=1;i--){
		printf("%d\n",i);
	}

	/*
	同じく >= は≧と同じでi=1の時も条件をみたすのでループ続行します。
	i--はiを1減らすということだったのでどんどんiが減っていきます。
	*/

	return 0;
}
```