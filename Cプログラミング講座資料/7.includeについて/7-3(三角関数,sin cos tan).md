```
#include<stdio.h>
#include<math.h>

int main(){
	
	double pi = 3.14;
	
	double a,b,c;
	
	a = sin(pi/3.0);
	b = cos(pi/3.0);
	c = tan(pi/3.0);
	
	printf("sin : %f,cos : %f,tan : %f \n",a,b,c);
	
	return 0;
}
```
#### 解説
sin,cos,tanは理系にはお馴染み（？）であろう。使い方はいたってそのままで、sinの後に入れたラジアンによって、数値を返す。今回はπ/3を入れたので、手計算で確認したり、中身をいじって変えてみても良い。