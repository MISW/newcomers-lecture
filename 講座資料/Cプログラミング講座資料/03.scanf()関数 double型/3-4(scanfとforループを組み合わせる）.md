#### 任意の数を1つ入力してもらい、2^nを求めるプログラム
```
#include<stdio.h>

int main(){
	int n,ans = 1,i;
	
	printf("2のn乗を求めます\n");
	printf("nを入れてください\n");
	scanf("%d",&n);
	
	for(i=0;i<n;i++){
		ans *= 2;
	}
	
	printf("2^%d = %d\n",n,ans);
	
	return 0;
}
```

#### 以下解説
```
#include<stdio.h>

int main(){
	int n,ans = 1,i;
	
	/*
	scanfで読み取るn
	答えを入れるans
	ループをまわすi
	を宣言します
	*/
	
	printf("2のn乗を求めます\n");
	printf("nを入れてください\n");
	scanf("%d",&n);
	
	
	for(i=0;i<n;i++){
		ans *= 2;
	}
	
	/*
	forの条件式のところにnがあります。
	これによりnに3が入ったならば
	for(i=0;i<3;i++)
	と同様になるので、3回ループが繰り返される事になります。
	*/
	
	printf("2^%d = %d\n",n,ans);
	
	/*
	実はprintfで %d は2回使ってもいいことになってます。
	その場合は n,ansのように順番ずつ打ち込む事になります。
	この場合,最初の%dにnの値が、次の%dにansの値が入ります。
	*/
	
	return 0;
	
}
```