#include <stdio.h>
#include <stdlib.h>

typedef struct node
{
	int key;
	struct node* right;
	struct node* left;
}Node;

void AddNode(Node** root, int data)
{
	Node* knot = *root, *back = NULL;

	while (knot != NULL)
	{
		if (data < knot->key)
		{
			back = knot;
			knot = knot->left;
		}
		else if (data > knot->key)
		{
			back = knot;
			knot = knot->right;
		}
		else return;
	}

	knot = (Node*)malloc(sizeof(Node));
	knot->key = data;
	knot->right = NULL;
	knot->left = NULL;

	if (back == NULL)
		*root = knot;
	else
	{
		if (data < back->key)
			back->left = knot;
		else
			back->right = knot;
	}
}

void Provero4ka(int* x)
{
	while (!scanf("%d", &(*x)))
	{
		printf("Тoлько целые числа!\n");
		while (getchar() != '\n');
	}
}

void Print(Node* knot, int l)
{
	if (knot != NULL)
	{
		Print(knot->right, l + 1);
		for (int i = 1; i <= l; i++) printf("    ");

		printf("%d", knot->key);
		printf("\n");
		Print(knot->left, l + 1);
	}
}

void Cleaning(Node* node)
{
	if (node->left != NULL)
		Cleaning(node->left);

	if (node->right != NULL)
		Cleaning(node->right);

	free(node);
}

int main()
{
	system("chcp 1251");
	system("cls");
	printf("Введите элементы дерева: \n");
	while (1)
	{
		Node* root = NULL;


		int x = 0;
		do
		{
			Provero4ka(&x);

			if (x != 0)	AddNode(&root, x);

		} while (x != 0);
		if (root != NULL) printf("\nДерево: \n");
		Print(root, 0);
		if (root != NULL) Cleaning(root);
	}
}