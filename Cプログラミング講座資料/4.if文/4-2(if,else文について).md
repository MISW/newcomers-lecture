```
#include <stdio.h>

int main(){
	int x = 7;
	
	if(x==5){
		printf("x は 5です！！！！！\n");
	}
	
	else{
		printf("xは5じゃありません。\n");
	}
	
	return 0;
}
```
#### 以下解説
```
#include <stdio.h>

int main(){
	int x = 7;
	
	if(x==5){
		printf("x は 5です！！！！！\n");
	}

	/*
	今回はxが5ではないので,x==5は真ではありません。
	つまり今回ifの{ } の中は実行されないことになります。
	*/

	else{
		printf("xは5じゃありません。\n");
	}

	/*
	そしてここで出てきたのがelse、
	これはifが実行されなかった場合はelseの{ }の中が実行されるということになります。
	またelse文は単体(if文がない場合)は使用不可能なので気をつけてください。
	*/
	
	
	return 0;
}
```
#### まとめ
else文の中身はifが実行されなかった場合に実行される。