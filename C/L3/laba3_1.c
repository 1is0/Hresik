#include "pch.h"
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <locale.h>
#include <malloc.h>

int main()
{
	setlocale(LC_ALL, "");
	int N, M, x, y;
	printf("Введите N: ");
	scanf_s("%d", &N);
	printf("Введите M: ");
	scanf_s("%d", &M);
	if (N < 1 || M < 1) {
		printf("\nERROR\n");
		return 0;
	}

	int **mas = (int **)malloc(N * sizeof(int *));
	for (int i = 0; i < N; i++) {
		mas[i] = (int *)malloc(M * sizeof(int));
	}

	printf("——————————————————————> y\n");
	printf("|\n");
	for (int i = 0; i < N; i++)
	{
		printf("| ");
		for (int j = 0; j < M; j++)
		{
			//mas[i][j] = 1;
			*(*(mas + i) + j) = 1;
			printf("%3d ", mas[i][j]);
		}
		printf("\n");
	} printf("v\nx\n\n");

	do
	{
		printf("Введите координаты по элемента по x : ");
		scanf_s("%d", &x);
		printf("введите координату по y : ");
		scanf_s("%d", &y);
		if (x == M && y - 1 == 0) break;
		if (x < 1 || y < 1 || x > M || y > N)
		{
			printf("\nERROR\n");
			return 0;
		}
		if (*(*(mas + (x - 1)) + (y - 1)) == 0)
			/*if (mas[x - 1][y - 1] == 0)*/
		{
			printf("\n\t\tЭтот кусок уже кто-то съел. Выбирай заново.\n\n");
			continue;
		}

		for (int i = 0; i < x; i++)
		{
			for (int j = y - 1; j < M; j++)
			{
				*(*(mas + i) + j) = 0;
			}
		}
		printf("——————————————————————> y\n");
		printf("|");
		for (int i = 0; i < N; i++)
		{

			puts("");	printf("| ");
			for (int j = 0; j < M; j++)
			{
				printf("%3d ", mas[i][j]);
			}

		}printf("\n");
		printf("v\nx\n\n");
	} while (1);
	printf("\n\t\tВы отравились и умерли. Игра окончена...\n\n");
	const char CSmile[] =
		"              ********\n"
		"         *****        *****\n"
		"       ***                 ***\n"
		"     ***                     ***\n"
		"    **                         **\n"
		"   *      ***      ***          **\n"
		"  *         **       **          **\n"
		" **          **       **         **\n"
		" *            **       **         **\n"
		"**            **       **         **\n"
		"**            **       **         **\n"
		"**                                **\n"
		" *                                **\n"
		" **            ********           **\n"
		"  **       ****        ****      **\n"
		"   **    ***              ***   **\n"
		"    **                         **\n"
		"      **                     **\n"
		"        ***               ***\n"
		"           ***************\n";

	printf("%s", CSmile);

	for (int i = 0; i < N; i++) {
		free(mas[i]);
	}
	free(mas);
	return 0;
}