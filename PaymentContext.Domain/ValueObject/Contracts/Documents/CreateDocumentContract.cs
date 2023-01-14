using Flunt.Validations;

namespace PaymentContext.Domain.ValueObject.Contracts.Documents
{
    public class CreateDocumentContract : Contract<Document>
    {
        public CreateDocumentContract(Document document)
        {
            Requires()
                .IsTrue(document.Validate(), "Document.Number", "Documento inválido");
        }
    }
}