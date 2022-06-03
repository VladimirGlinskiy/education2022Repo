
namespace CSharp
{
    public abstract class NullTokenVisitor : ITokenVisitor
    {
        public virtual void Visit(ILineStartToken lineStartToken) { }
        public virtual void Visit(ILineEndToken lineEndToken) { }
        public virtual void Visit(ICommentToken commentToken) { }
        public virtual void Visit(IDirectiveToken t) { }
        public virtual void Visit(IIdentifierToken identifierToken) { }
        public virtual void Visit(IKeywordToken keywordToken) { }
        public virtual void Visit(IWhiteSpaceToken whiteSpaceToken) { }
        public virtual void Visit(IOtherToken otherToken) { }

    }
}
