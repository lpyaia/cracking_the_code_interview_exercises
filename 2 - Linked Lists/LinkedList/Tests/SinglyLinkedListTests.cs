using FluentAssertions;
using LinkedList;
using Xunit;

namespace Tests
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void GivenASimpleList_WhenCreatingANewOne_ShouldDefineHeadAndLastAsTheSame()
        {
            // arrange
            var node = new Node<int>(1);
            var lst = new SinglyLinkedList<int>(node);

            // assert
            lst.Head.Should().Be(lst.Head);
            lst.Head.Value.Should().Be(node.Value);
        }

        [Fact]
        public void GivenASimpleList_WhenAddingNewNodes_ShouldAppendToTheLast()
        {
            // arrange
            var node = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            var node4 = new Node<int>(4);

            var lst = new SinglyLinkedList<int>(node);

            // act
            lst.Add(node2);
            lst.Add(node3);
            lst.Add(node4);

            // assert
            lst.Head.Should().NotBe(lst.Last);
            lst.Last.Should().Be(node4);
            lst.Head.Next.Should().Be(node2);
            lst.Head.Next.Next.Should().Be(node3);
            lst.Head.Next.Next.Next.Should().Be(node4);
            lst.Head.Value.Should().Be(node.Value);
            lst.Length.Should().Be(4);
        }

        [Fact]
        public void GivenASimpleList_WhenRemovingNode_ShouldUpdateTheList()
        {
            // arrange
            var node = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            var node4 = new Node<int>(4);
            var node5 = new Node<int>(5);
            var node6 = new Node<int>(6);

            var lst = new SinglyLinkedList<int>(node);

            // act
            lst.Add(node2);
            lst.Add(node3);
            lst.Add(node4);
            lst.Add(node5);
            lst.Add(node6);

            lst.Remove(node3);

            // assert
            lst.Length.Should().Be(5);

            lst.Head.Should().Be(node);
            lst.Head.Next.Should().Be(node2);
            lst.Head.Next.Next.Should().Be(node4);
            lst.Head.Next.Next.Next.Should().Be(node5);
            lst.Head.Next.Next.Next.Next.Should().Be(node6);

            lst.Last.Should().Be(node6);
        }

        [Fact]
        public void GivenASimpleList_WhenRemovingHeadNode_ShouldUpdateTheList()
        {
            // arrange
            var node = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            var node4 = new Node<int>(4);
            var node5 = new Node<int>(5);
            var node6 = new Node<int>(6);

            var lst = new SinglyLinkedList<int>(node);

            // act
            lst.Add(node2);
            lst.Add(node3);
            lst.Add(node4);
            lst.Add(node5);
            lst.Add(node6);

            lst.Remove(node);

            // assert
            lst.Length.Should().Be(5);

            lst.Head.Should().Be(node2);
            lst.Head.Next.Should().Be(node3);
            lst.Head.Next.Next.Should().Be(node4);
            lst.Head.Next.Next.Next.Should().Be(node5);
            lst.Head.Next.Next.Next.Next.Should().Be(node6);

            lst.Last.Should().Be(node6);
        }

        [Fact]
        public void GivenASimpleList_WhenRemovingLastNode_ShouldUpdateTheList()
        {
            // arrange
            var node = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            var node4 = new Node<int>(4);
            var node5 = new Node<int>(5);
            var node6 = new Node<int>(6);

            var lst = new SinglyLinkedList<int>(node);

            // act
            lst.Add(node2);
            lst.Add(node3);
            lst.Add(node4);
            lst.Add(node5);
            lst.Add(node6);

            lst.Remove(node6);

            // assert
            lst.Length.Should().Be(5);

            lst.Head.Should().Be(node);
            lst.Head.Next.Should().Be(node2);
            lst.Head.Next.Next.Should().Be(node3);
            lst.Head.Next.Next.Next.Should().Be(node4);
            lst.Head.Next.Next.Next.Next.Should().Be(node5);

            lst.Last.Should().Be(node5);
        }
    }
}