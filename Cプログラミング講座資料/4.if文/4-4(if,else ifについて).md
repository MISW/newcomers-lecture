```
#include<stdio.h>

int main(){
	
	int x = -5;
	
	if(x > 0){
		printf("xは0より大きいです。\n");
	}
	
	else if(x < 0){
		printf("xは0より小さいです。\n");
	}
	
	return 0;
}
```

#### 以下解説
```
#include<stdio.h>

int main(){
	
	int x = -5;

	/*
	今まで変数に代入するものは正の値ばかりでしたが、
	負の値を代入することも可能です。
	*/
	
	if(x > 0){
		printf("xは0より大きいです。\n");
	}

	/*
	今回xは負なのでx>0は満たさない
	*/
	
	else if(x < 0){
		printf("xは0より小さいです。\n");
	}

	/*
	そして今回出てきたelse if文
	これは上にあるif文が実行されなかった場合,
	else if文の条件式を見て実行するか決めます。
	else文と違うのは条件式があるところです。
	なのでxが0だった場合このプログラムは何も表示されないことがある、ということです。
	*/

	return 0;
}
```