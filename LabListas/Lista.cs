using System.Collections;
using System.Collections.Generic;

namespace LabListas
{
    public class Nodo<T>
    {
        public T Value { get; set; }
        public Nodo<T> Next { get; set; }

        public Nodo(T value)
        {
            Value = value;
            Next = null;
        }
    }

    public class ListaEnlazada<T> : IEnumerable<T>
    {
        public Nodo<T> First { get; private set; }
        public Nodo<T> Last { get; private set; }

        public void AddLast(T value)
        {
            var nuevo = new Nodo<T>(value); //se crea un nuevo nodo con el valor proporcionado



            if (First == null)
            {
                First = nuevo;
                Last = nuevo;
                return;
            }/*si la lista esta vacia
              se agrega el nuevo nodo y ese mismo se convierte en el ultimo y el primero*/

            Last.Next = nuevo;//si la lista no esta vacia, el nodo que actualmente es el ultimo apunta al nuevo nodo
            Last = nuevo;//el nuevo nodo se convierte en el ultimo de la lista
        }

        public void AddFirst(T value)
        {
            var nuevo = new Nodo<T>(value);//se crea un nuevo nodo con el valor proporcionado

            if (First == null)
            {
                First = nuevo;
                Last = nuevo;
                return;
            }/*si la lista esta vacia
              se agrega el nuevo nodo y ese mismo se convierte en el primero y el ultimo*/

            nuevo.Next = First;//el nuevo nodo apunta al nodo que actualmente es el primero
            First = nuevo;//el nuevo nodo se convierte en el primero de la lista
        }

        // Elimina un nodo. Necesita el "anterior" porque no hay .Previous
        public void Remove(Nodo<T> nodo, Nodo<T> anterior)
        {
            if (anterior == null)
                First = nodo.Next; // era el primero de la lista
            else
                anterior.Next = nodo.Next;// el nodo anterior ahora apunta al siguiente del nodo que se elimina

            if (nodo == Last)
                Last = anterior;// si el nodo eliminado era el ultimo, actualizamos Last
        }

        public IEnumerator<T> GetEnumerator()
        {
            var actual = First;// empezamos desde el primer nodo
            while (actual != null)// mientras haya nodos
            {
                yield return actual.Value;// devolvemos el valor del nodo actual
                actual = actual.Next;// avanzamos al siguiente nodo
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();// implementación explícita de IEnumerable

        public void AddAt(int index, T value)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));// índice negativo no es válido

            // Caso especial: insertar en la posicion 0 es igual que AddFirst
            if (index == 0)
            {
                AddFirst(value);
                return;// si el índice es 0, simplemente agregamos al inicio de la lista
            }

            // Recorremos hasta el nodo que quedara JUSTO ANTES de la posicion deseada
            var anterior = First;// empezamos desde el primer nodo
            int i = 0;// contador de posición
            while (i < index - 1)// queremos llegar al nodo anterior al índice deseado
            {
                if (anterior == null)// si llegamos al final de la lista antes de alcanzar el índice, lanzamos una excepción
                    throw new ArgumentOutOfRangeException(nameof(index), "Indice fuera de rango.");
                anterior = anterior.Next;// avanzamos al siguiente nodo
                i++;// incrementamos el contador de posición
            }

            if (anterior == null)
                throw new ArgumentOutOfRangeException(nameof(index), "Indice fuera de rango.");// si el nodo anterior es null, significa que el índice es inválido

            var nuevo = new Nodo<T>(value);// creamos un nuevo nodo con el valor proporcionado
            nuevo.Next = anterior.Next;  // el nuevo nodo se conecta hacia adelante
            anterior.Next = nuevo;        // el nodo anterior ahora apunta al nuevo

            if (nuevo.Next == null) // si el nuevo nodo quedó al final de la lista
                Last = nuevo; // si quedo al final, actualizamos Last
        }
    }
}