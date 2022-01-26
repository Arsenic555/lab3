//Класс товара
class Product {
	constructor(art, name, ammount, desc, img)
	{
		this.art = art;
		this.name = name;
		this.ammount = ammount;
		this.desc = desc;
		this.img = img;
	}
	
	inc_ammo(ammo)
	{
		this.ammount += ammo;
	}
	
	dec_ammo(ammo)
	{
		this.ammount -= ammo;
	}
}

//Глобальный массив каталог со всеми товарами, загружается из файла
var catalog = [];

//Тележка с товарами пользователя
var cart = [];

//Артикул выбранного товара
var cur = catalog[0].art;

//Показывает товар
function ShowProduct(art)
{
	cur = art
	product = catalog[GetInd(art)]
	document.getElementById("mp_img").innerHTML= "<img src=\"" + product.art +".png\" height = 560 width = 1000>";
	document.getElementById("ab_name").innerHTML= product.name;
	if (product.ammount == 0)
	{
		document.getElementById("ab_ammo").innerHTML= "Товара нет в наличии";
	}
	else
	{
		document.getElementById("ab_ammo").innerHTML= "Товаров на складе: " + product.ammount;
	}
	document.getElementById("ab_desc").innerHTML =product.desc;
}

//Добавляет товар в корзину
function addtocart(art)
{
	if (catalog[art].ammount == 0)
	{
		alert("Данного товара нет в наличии. Извините!");
	}
	else
	{
		if (InCart(art))
		{
			alert("Товар уже добавлен в корзину!");
		}
		else
		{
		cart.push(new Product(catalog[GetInd(art)].name, catalog[GetInd(art)].art, catalog[GetInd(art)].price, 1, catalog[GetInd(art)].desc));
		}
	}
}

//Проверяет есть ли товар в корзине
function InCart(art)
{
	result = false;
	cart.forEach((prod, i , cart)=>{
		if (prod.art == art)
		{
			result = true;
		}
	});
	return result;
}

//Отображает содержимое корзины в меню
function DisplayCart()
{
	if (cart.length == 0)
	{
		document.getElementById("items_in_cart").innerHTML= "Корзина пуста";
	}
	else
	{
	document.getElementById("items_in_cart").innerHTML= cart.length + Grammy() + " на сумму " + CountSum() + "руб.";
	}
}

//Считает сумму заказа
function CountSum()
{
	result = 0;
	cart.forEach((prod, i, cart)=>{
		result+=prod.price*prod.ammount;
	});
	return result;
}

function cart_button()
{
	if (cart_shown == true)
	{
		cart_shown = false;
		document.getElementById("shop_list").setAttribute("style", "display:none");
	}
	else
	{
		cart_shown = true;
		document.getElementById("shop_list").setAttribute("style", "display:grid");
		SetOrderPanel();
	}
}

function GetArray(array)
{
	alert("W");
	catalog = array;
}

//Отображает панель оформления заказа
function SetOrderPanel()
{
	
}

function main()
{
	//alert("works");
	alert(catalog[0].name);
}

//main();
	