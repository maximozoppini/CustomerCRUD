using AutoMapper;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using SimpleCRUD.Entities.DBContext;
using SimpleCRUD.Services.DTOs;

namespace SimpleCRUD.Services.Customers.Querys
{
    public class CustomerQuery : ObjectGraphType
    {
        public CustomerQuery(IMapper _mapper, CustomerAssestmentContext db)
        {
            Field<ListGraphType<CustomerType>>(
                "customers",
                resolve: context => _mapper.Map<List<CustomerDTO>>(db.Customers.ToList())

            );
        }
       
    }

    public class CustomerType : ObjectGraphType<CustomerDTO>
    {
        public CustomerType()
        {
            Field(x => x.Id);
            Field(x => x.FirstName);
            Field(x => x.LastName);
            Field(x => x.Email);
        }
    }

    public class GraphQLSchema : Schema
    {
        public GraphQLSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<CustomerQuery>();
        }
    }
}
