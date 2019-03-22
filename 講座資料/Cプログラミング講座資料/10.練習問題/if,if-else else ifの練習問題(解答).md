1.
```
#include<stdio.h>

int main(){
	
	int a;
	
	scanf("%d",&a);
	
	if(a>=100){
		printf("100以上の数を受け取りました。\n");
	}
	
	else{
		printf("100未満の数を受け取りました。\n");
	}
	
	return 0;
}
```
2.
```
#include<stdio.h>

int main(){
	
	int a;
	scanf("%d",&a);
	
	if(a%2==0){
		printf("%dは偶数です。\n",a);
	}
	
	else{
		printf("%dは奇数です。\n",a);
	}
	
	return 0;
}
```
3.
```
#include<stdio.h>

int main(){
	
	double a;
	
	scanf("%lf",&a);
	
	if(a<0){
		printf("0未満の数を受け取りました。\n");
	}
	
	else if(a >= 0 && a <= 100){
		printf("0以上,100以下の数を受け取りました。\n");
	}
	
	else{
		printf("100より大きい数を受け取りました。\n");
	}
	
	return 0;
}
```
4.
```
#include<stdio.h>

void IsLeapYear(int year){
	
	if(year % 400==0){
		printf("%d年はうるう年です。\n",year);
	}
	else if(year % 100 ==0){
		printf("%d年はうるう年ではありません。\n",year);
	}
	else if(year % 4 == 0){
		printf("%d年はうるう年です。\n",year);
	}
	else{
		printf("%d年はうるう年ではありません。\n",year);
	}
}

int main(){
	
	IsLeapYear(2004);
	
	return 0;
}
```