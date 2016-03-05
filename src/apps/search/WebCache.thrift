
namespace cpp dsn.app.search
namespace csharp dsn.app.search

struct StringQuery
{
	1: string Query;
}

struct ErrorResult
{
	1: i32 ErrorCode;
}

struct AugmentedQuery
{
    1: i32 QueryId;
    2: StringQuery RawQuery;
    3: StringQuery AlteredQuery;
    4: i32 TopX;
}

struct DocId
{
    1: string URL;
}

struct Caption
{
    1: DocId DocIdentifier;
    2: string Title;
    3: string CaptionHtml;
}

struct QueryResult
{
    1: StringQuery RawQuery;
    2: AugmentedQuery Query;
    3: list<Caption> Results;
}

service WebCache
{
    QueryResult Get(1:AugmentedQuery query);
    ErrorResult Put(1:QueryResult result);
}
