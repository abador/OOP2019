using System;
/*
 * Stwórz generator map.
interface IMapa {
public void generate(); //generowanie mapy na podstawie podanych wymiarów
public void list(); //wyśœietlenie informacji na temat każdego elementu dodanego do mapy
public void show(); // wyświetlenie mapy
}
Klasa Mapa implementująca interfejs IMapa:
powinna inicjować tabglicę o wilekości zgodnej z tym co poda użytkownik.
Klasa Point: powinna zawierać współrzędne x i y oraz metodę print() - która wyświetli te współrzędne
Klasa MapElement dziedziczy po Point i zawiera atrybut icon (pojedynczy char, który będzie się wyświetlał w konsoli przy generowaniu mapy)
Klasa Grass: dziedziczy po MapElement, i ma ustawioną ikonę jako G i implementuje włąsną metodę print z informacją, zę to jest trawa + współrzędne
Klasa Tree: dziedziczy po MapElement, i ma ustawioną ikonę jako T i implementuje włąsną metodę print z informacją, zę to jest drzewo + współrzędne
Klasa Rock: dziedziczy po MapElement, i ma ustawioną ikonę jako R i implementuje włąsną metodę print z informacją, zę to jest kamień + współrzędne

2. Dodanie klasy Bomb dziedziczącej po jednej z wcześniej wymienionych klas(tej która ma najwięcej sensu, proszę uzasadnić), zawierające atrybut level oraz name i włąsną metodę print.
Pole na którym znajduje się bomba będzie generowane losowo. Następnie użytkownik moze podać współrzędne gdzie podejrzewa, ze znajduje się bomba. nalezy sprawdzić czy trafił
 * 
 * 
 * 
 * */
namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rock rock = new Rock(10, 10);
            rock.print();
            Bomb bomb = new Bomb();
            bomb.print();

        }
    }
}
