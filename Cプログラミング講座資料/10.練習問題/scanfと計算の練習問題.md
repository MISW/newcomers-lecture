#### 1.  
整数をscanfにて2回受け取り、  
（最初に受け取った数）-（後に受け取った数）の計算結果を出力せよ。  
  
#### 2.  
四角形の縦の長さと横の長さを受け取り、  
その四角形の面積を出力するプログラムを作れ。  
縦の長さと横の長さは整数とする。  
  
#### 3.  
三角形の底辺の長さと高さを受け取り、  
その三角形の面積を出力するプログラムを作れ。  
今回の辺の長さは小数も可能とする。  
ヒント:double型のscanfの指定子は%lf  
  
#### 4.  
10の正の平方根を表示するプログラムを作れ。  
math.hをincludeすることは可能とする。  
  
#### 5.  
適当な正の整数を1つ受け取り、  
その整数の平方根を表示するプログラムを作れ。  
math.hをincludeすることは可能とする。  
  
#### 6.
直角三角形の斜辺以外の2辺を受け取り、  
その時の斜辺の長さを表示するプログラムを作れ。  
全ての辺の長さは小数可能。  
math.hをincludeすることも可能とする。  


1.
#include<stdio.h>

int main(){
	
	int a,b;
	printf("1つめの整数を入力して下さい\n");
	scanf("%d",&a);
	printf("2つめの整数を入力して下さい\n");
	scanf("%d",&b);
	
	printf("%d - %d = %d\n",a,b,a-b);
	
	return 0;
}

2.
#include<stdio.h>

int main(){
	
	int a,b;
	printf("四角形の縦の長さを入力して下さい。\n");
	scanf("%d",&a);
	
	printf("四角形の横の長さを入力して下さい。\n");
	scanf("%d",&b);
	
	printf("この四角形の面積は %d です。\n",a*b);
	
	return 0;
}

3.
#include<stdio.h>

int main(){
	
	double a,b;
	printf("三角形の底辺の長さを入力して下さい。\n");
	scanf("%lf",&a);
	
	printf("三角形の高さを入力して下さい。\n");
	scanf("%lf",&b);
	
	printf("三角形の面積は %f です。\n",a*b/2.0);
	
	return 0;
}

4.
#include<stdio.h>
#include<math.h>

int main(){
	
	printf("10の平方根は%fです。",sqrt(10));
	
	return 0;
}

5.
#include<stdio.h>
#include<math.h>

int main(){
	
	int a;
	printf("整数を一つ入力して下さい。\n");
	scanf("%d",&a);
	
	printf("%d の 平方根は %f です。",a,sqrt(a));
	
	return 0;
}

6.
#include<stdio.h>
#include<math.h>

int main(){
	
	double a,b,c;
	printf("直角三角形の斜辺以外の2辺の長さを入力して下さい。\n");
	printf("1つめを入力して下さい。\n");
	scanf("%lf",&a);
	
	printf("2つめを入力して下さい。\n");
	scanf("%lf",&b);
	
	c = sqrt(a*a+b*b);
	
	printf("この時、斜辺の長さは%fです。\n",c);
	
	return 0;
}


全ての問題で気を付けなければいけないのは、
scanfで入れたい変数の前に&を付け忘れないことである。
