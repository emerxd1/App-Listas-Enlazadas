using System;
using System.Collections;
using System.Collections.Generic;

namespace LabListas
{
    // ---------- LISTA DOBLEMENTE ENLAZADA (usada por Shift) ----------

    public class NodoDE<T>
    {
        public T Value { get; set; }
        public NodoDE<T> Next { get; set; }
        public NodoDE<T> Previous { get; set; } // puntero hacia atras

        public NodoDE(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }

    public class ListaDE<T> : IEnumerable<T>
    {
        public NodoDE<T> First { get; private set; }
        public NodoDE<T> Last { get; private set; }

        public void AddLast(T value)
        {
            var nuevo = new NodoDE<T>(value); //se crea un nuevo nodo con el valor proporcionado

            if (First == null)
            {
                First = nuevo;
                Last = nuevo;
                return;
            }/*si la lista esta vacia
              se agrega el nuevo nodo y ese mismo se convierte en el ultimo y el primero*/

            nuevo.Previous = Last;//el nuevo nodo apunta hacia atras al que era el ultimo
            Last.Next = nuevo;//si la lista no esta vacia, el nodo que actualmente es el ultimo apunta al nuevo nodo
            Last = nuevo;//el nuevo nodo se convierte en el ultimo de la lista
        }

        public void AddFirst(T value)
        {
            var nuevo = new NodoDE<T>(value);//se crea un nuevo nodo con el valor proporcionado

            if (First == null)
            {
                First = nuevo;
                Last = nuevo;
                return;
            }/*si la lista esta vacia
              se agrega el nuevo nodo y ese mismo se convierte en el primero y el ultimo*/

            nuevo.Next = First;//el nuevo nodo apunta hacia adelante al nodo que actualmente es el primero
            First.Previous = nuevo;//el que era el primero ahora apunta hacia atras al nuevo nodo
            First = nuevo;//el nuevo nodo se convierte en el primero de la lista
        }

        // Ya NO necesita "anterior": con Previous alcanza para reconectar la lista.
        public void Remove(NodoDE<T> nodo)
        {
            if (nodo == null)
                return;

            if (nodo.Previous != null)
                nodo.Previous.Next = nodo.Next; // el nodo anterior salta directo al siguiente
            else
                First = nodo.Next; // el nodo eliminado era el primero

            if (nodo.Next != null)
                nodo.Next.Previous = nodo.Previous; // el nodo siguiente salta directo al anterior
            else
                Last = nodo.Previous; // el nodo eliminado era el ultimo

            nodo.Next = null;
            nodo.Previous = null;
        }

        public int Count()
        {
            int contador = 0;
            var actual = First;
            while (actual != null)
            {
                contador++;
                actual = actual.Next;
            }
            return contador;
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

        // Recorre la lista de atras hacia adelante, gracias a Previous
        public IEnumerable<T> RecorrerHaciaAtras()
        {
            var actual = Last;// empezamos desde el ultimo nodo
            while (actual != null)
            {
                yield return actual.Value;
                actual = actual.Previous;// retrocedemos al nodo anterior
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

            var anterior = First;// empezamos desde el primer nodo
            int i = 0;// contador de posición
            while (i < index - 1)// queremos llegar al nodo anterior al índice deseado
            {
                if (anterior == null)
                    throw new ArgumentOutOfRangeException(nameof(index), "Indice fuera de rango.");
                anterior = anterior.Next;// avanzamos al siguiente nodo
                i++;// incrementamos el contador de posición
            }

            if (anterior == null)
                throw new ArgumentOutOfRangeException(nameof(index), "Indice fuera de rango.");

            var nuevo = new NodoDE<T>(value);
            nuevo.Next = anterior.Next;   // el nuevo nodo se conecta hacia adelante
            nuevo.Previous = anterior;    // el nuevo nodo se conecta hacia atras con el anterior

            if (anterior.Next != null)
                anterior.Next.Previous = nuevo; // el que era el siguiente ahora apunta hacia atras al nuevo

            anterior.Next = nuevo;        // el nodo anterior ahora apunta al nuevo

            if (nuevo.Next == null) // si el nuevo nodo quedó al final de la lista
                Last = nuevo;
        }
    }
}