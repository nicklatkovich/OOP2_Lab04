using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab04 {
    class CollectionType<T> : ISet<T> where T : IComparable {

        private SortedSet<T> _set;

        public CollectionType( ) {
            _set = new SortedSet<T>( );
        }

        public CollectionType(IEnumerable<T> set) : this( ) {
            UnionWith(set);
        }

        public uint NumberOfValues(T value) {
            return (_set.Contains(value) ? 1u : 0u);
        }

        public CollectionType<T> GetAllButFirst3( ) {
            CollectionType<T> result = new CollectionType<T>( );
            uint counter = 0u;
            foreach (T t in _set) {
                counter++;
                if (counter > 3) {
                    result.Add(t);
                }
            }
            return result;
        }

        /*
         * Impliment
         */
        public Int32 Count {
            get {
                return _set.Count;
            }
        }

        public Boolean IsReadOnly {
            get {
                throw new NotImplementedException( );
            }
        }

        public Boolean Add(T item) {
            return _set.Add(item);
        }

        public void Clear( ) {
            _set.Clear( );
        }

        public Boolean Contains(T item) {
            return _set.Contains(item);
        }

        public void CopyTo(T[ ] array, Int32 arrayIndex) {
            _set.CopyTo(array, arrayIndex);
        }

        public void ExceptWith(IEnumerable<T> other) {
            _set.ExceptWith(other);
        }

        public IEnumerator<T> GetEnumerator( ) {
            return _set.GetEnumerator( );
        }

        public void IntersectWith(IEnumerable<T> other) {
            _set.IntersectWith(other);
        }

        public Boolean IsProperSubsetOf(IEnumerable<T> other) {
            return _set.IsProperSubsetOf(other);
        }

        public Boolean IsProperSupersetOf(IEnumerable<T> other) {
            return _set.IsProperSupersetOf(other);
        }

        public Boolean IsSubsetOf(IEnumerable<T> other) {
            return _set.IsSubsetOf(other);
        }

        public Boolean IsSupersetOf(IEnumerable<T> other) {
            return _set.IsSupersetOf(other);
        }

        public Boolean Overlaps(IEnumerable<T> other) {
            return _set.Overlaps(other);
        }

        public Boolean Remove(T item) {
            return _set.Remove(item);
        }

        public Boolean SetEquals(IEnumerable<T> other) {
            return _set.SetEquals(other);
        }

        public void SymmetricExceptWith(IEnumerable<T> other) {
            _set.SymmetricExceptWith(other);
        }

        public void UnionWith(IEnumerable<T> other) {
            _set.UnionWith(other);
        }

        void ICollection<T>.Add(T item) {
            _set.Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator( ) {
            return _set.GetEnumerator( );
        }
    }
}
