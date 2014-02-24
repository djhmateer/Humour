using Humour.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Humour.Tests.Unit
{
    [TestClass]
    public class DomainEntityTests
    {
        internal class StoryWithIntAsId : DomainEntity<int>
        {
            public override IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext)
            {
                yield break;
            }
            //public override System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext)
            //{
            //    throw new NotImplementedException();
            //}
        }

        [TestMethod]
        public void NewStoryWithIntAsIdIsTransient()
        {
            var story = new StoryWithIntAsId();
            story.IsTransient().Should().BeTrue();
        }

        [TestMethod]
        public void WithIntAsIdWithValueIsNotTransient()
        {
            var story = new StoryWithIntAsId { Id = 4 };
            story.IsTransient().Should().BeFalse();
        }

        [TestMethod]
        public void SameIdentityProduceEqualsTrueTest()
        {
            var entityLeft = new StoryWithIntAsId { Id = 1 };
            var entityRight = new StoryWithIntAsId { Id = 1 };

            //Act
            bool resultOnEquals = entityLeft.Equals(entityRight);
            bool resultOnOperator = entityLeft == entityRight;

            //Assert
            resultOnEquals.Should().BeTrue();
            resultOnOperator.Should().BeTrue();
        }

        [TestMethod]
        public void DifferentIdProduceEqualsFalseTest()
        {
            //Arrange
            var entityLeft = new StoryWithIntAsId { Id = 1 };
            var entityRight = new StoryWithIntAsId { Id = 2 };

            //Act
            bool resultOnEquals = entityLeft.Equals(entityRight);
            bool resultOnOperator = entityLeft == entityRight;

            //Assert
            resultOnEquals.Should().BeFalse();
            resultOnOperator.Should().BeFalse();
        }

        [TestMethod]
        public void CompareUsingEqualsOperatorsAndNullOperandsTest()
        {
            //Arrange

            StoryWithIntAsId entityLeft = null;
            StoryWithIntAsId entityRight = new StoryWithIntAsId { Id = 2 };

            //Act
            if (!(entityLeft == (StoryWithIntAsId)null))
                Assert.Fail();

            if (!(entityRight != (StoryWithIntAsId)null))
                Assert.Fail();

            entityRight = null;

            //Act
            if (!(entityLeft == entityRight))
                Assert.Fail();

            if (entityLeft != entityRight)
                Assert.Fail();
        }

        [TestMethod]
        public void CompareTheSameReferenceReturnTrueTest()
        {
            //Arrange
            var entityLeft = new StoryWithIntAsId();
            StoryWithIntAsId entityRight = entityLeft;

            //Act
            if (!entityLeft.Equals(entityRight))
            {
                Assert.Fail();
            }

            if (!(entityLeft == entityRight))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void CompareWhenLeftIsNullAndRightIsNullReturnFalseTest()
        {
            //Arrange
            StoryWithIntAsId entityLeft = null;
            var entityRight = new StoryWithIntAsId { Id = 1 };

            //Act
            if (!(entityLeft == (StoryWithIntAsId)null))//this perform ==(left,right)
            {
                Assert.Fail();
            }

            if (!(entityRight != (StoryWithIntAsId)null))//this perform !=(left,right)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void SetIdentitySetANonTransientEntity()
        {
            //Arrange
            var entity = new StoryWithIntAsId { Id = 1 };

            //Assert
            Assert.IsFalse(entity.IsTransient());
        }
    }
}
