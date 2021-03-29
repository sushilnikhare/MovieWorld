// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Movies.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CinemaWorld.Grpc {

  /// <summary>Holder for reflection information generated from Movies.proto</summary>
  public static partial class MoviesReflection {

    #region Descriptor
    /// <summary>File descriptor for Movies.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MoviesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxNb3ZpZXMucHJvdG8SA0FQSSIVChNHZXRBbGxNb3ZpZXNSZXF1ZXN0IjIK",
            "FEdldEFsbE1vdmllc1Jlc3BvbnNlEhoKBk1vdmllcxgBIAMoCzIKLkFQSS5N",
            "b3ZpZSImChNHZXRCeU1vdmllSWRSZXF1ZXN0Eg8KB01vdmllSWQYASABKAki",
            "MQoUR2V0QnlNb3ZpZUlkUmVzcG9uc2USGQoFTW92aWUYASABKAsyCi5BUEku",
            "TW92aWUiPwoFTW92aWUSDwoHTW92aWVJZBgBIAEoCRIRCglNb3ZpZU5hbWUY",
            "AiABKAkSEgoKTW92aWVQcmljZRgDIAEoCTKMAQoGTW92aWVzEj0KBkdldEFs",
            "bBIYLkFQSS5HZXRBbGxNb3ZpZXNSZXF1ZXN0GhkuQVBJLkdldEFsbE1vdmll",
            "c1Jlc3BvbnNlEkMKDEdldEJ5TW92aWVJZBIYLkFQSS5HZXRCeU1vdmllSWRS",
            "ZXF1ZXN0GhkuQVBJLkdldEJ5TW92aWVJZFJlc3BvbnNlQhOqAhBDaW5lbWFX",
            "b3JsZC5HcnBjYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CinemaWorld.Grpc.GetAllMoviesRequest), global::CinemaWorld.Grpc.GetAllMoviesRequest.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CinemaWorld.Grpc.GetAllMoviesResponse), global::CinemaWorld.Grpc.GetAllMoviesResponse.Parser, new[]{ "Movies" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CinemaWorld.Grpc.GetByMovieIdRequest), global::CinemaWorld.Grpc.GetByMovieIdRequest.Parser, new[]{ "MovieId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CinemaWorld.Grpc.GetByMovieIdResponse), global::CinemaWorld.Grpc.GetByMovieIdResponse.Parser, new[]{ "Movie" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CinemaWorld.Grpc.Movie), global::CinemaWorld.Grpc.Movie.Parser, new[]{ "MovieId", "MovieName", "MoviePrice" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetAllMoviesRequest : pb::IMessage<GetAllMoviesRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAllMoviesRequest> _parser = new pb::MessageParser<GetAllMoviesRequest>(() => new GetAllMoviesRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAllMoviesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CinemaWorld.Grpc.MoviesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllMoviesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllMoviesRequest(GetAllMoviesRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllMoviesRequest Clone() {
      return new GetAllMoviesRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAllMoviesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAllMoviesRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAllMoviesRequest other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

  }

  public sealed partial class GetAllMoviesResponse : pb::IMessage<GetAllMoviesResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAllMoviesResponse> _parser = new pb::MessageParser<GetAllMoviesResponse>(() => new GetAllMoviesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAllMoviesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CinemaWorld.Grpc.MoviesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllMoviesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllMoviesResponse(GetAllMoviesResponse other) : this() {
      movies_ = other.movies_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllMoviesResponse Clone() {
      return new GetAllMoviesResponse(this);
    }

    /// <summary>Field number for the "Movies" field.</summary>
    public const int MoviesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CinemaWorld.Grpc.Movie> _repeated_movies_codec
        = pb::FieldCodec.ForMessage(10, global::CinemaWorld.Grpc.Movie.Parser);
    private readonly pbc::RepeatedField<global::CinemaWorld.Grpc.Movie> movies_ = new pbc::RepeatedField<global::CinemaWorld.Grpc.Movie>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CinemaWorld.Grpc.Movie> Movies {
      get { return movies_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAllMoviesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAllMoviesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!movies_.Equals(other.movies_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= movies_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      movies_.WriteTo(output, _repeated_movies_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      movies_.WriteTo(ref output, _repeated_movies_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += movies_.CalculateSize(_repeated_movies_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAllMoviesResponse other) {
      if (other == null) {
        return;
      }
      movies_.Add(other.movies_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            movies_.AddEntriesFrom(input, _repeated_movies_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            movies_.AddEntriesFrom(ref input, _repeated_movies_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GetByMovieIdRequest : pb::IMessage<GetByMovieIdRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetByMovieIdRequest> _parser = new pb::MessageParser<GetByMovieIdRequest>(() => new GetByMovieIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetByMovieIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CinemaWorld.Grpc.MoviesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByMovieIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByMovieIdRequest(GetByMovieIdRequest other) : this() {
      movieId_ = other.movieId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByMovieIdRequest Clone() {
      return new GetByMovieIdRequest(this);
    }

    /// <summary>Field number for the "MovieId" field.</summary>
    public const int MovieIdFieldNumber = 1;
    private string movieId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MovieId {
      get { return movieId_; }
      set {
        movieId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetByMovieIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetByMovieIdRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MovieId != other.MovieId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MovieId.Length != 0) hash ^= MovieId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (MovieId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MovieId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MovieId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MovieId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MovieId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MovieId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetByMovieIdRequest other) {
      if (other == null) {
        return;
      }
      if (other.MovieId.Length != 0) {
        MovieId = other.MovieId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            MovieId = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            MovieId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GetByMovieIdResponse : pb::IMessage<GetByMovieIdResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetByMovieIdResponse> _parser = new pb::MessageParser<GetByMovieIdResponse>(() => new GetByMovieIdResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetByMovieIdResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CinemaWorld.Grpc.MoviesReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByMovieIdResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByMovieIdResponse(GetByMovieIdResponse other) : this() {
      movie_ = other.movie_ != null ? other.movie_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByMovieIdResponse Clone() {
      return new GetByMovieIdResponse(this);
    }

    /// <summary>Field number for the "Movie" field.</summary>
    public const int MovieFieldNumber = 1;
    private global::CinemaWorld.Grpc.Movie movie_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::CinemaWorld.Grpc.Movie Movie {
      get { return movie_; }
      set {
        movie_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetByMovieIdResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetByMovieIdResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Movie, other.Movie)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (movie_ != null) hash ^= Movie.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (movie_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Movie);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (movie_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Movie);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (movie_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Movie);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetByMovieIdResponse other) {
      if (other == null) {
        return;
      }
      if (other.movie_ != null) {
        if (movie_ == null) {
          Movie = new global::CinemaWorld.Grpc.Movie();
        }
        Movie.MergeFrom(other.Movie);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (movie_ == null) {
              Movie = new global::CinemaWorld.Grpc.Movie();
            }
            input.ReadMessage(Movie);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (movie_ == null) {
              Movie = new global::CinemaWorld.Grpc.Movie();
            }
            input.ReadMessage(Movie);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Movie : pb::IMessage<Movie>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Movie> _parser = new pb::MessageParser<Movie>(() => new Movie());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Movie> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CinemaWorld.Grpc.MoviesReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Movie() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Movie(Movie other) : this() {
      movieId_ = other.movieId_;
      movieName_ = other.movieName_;
      moviePrice_ = other.moviePrice_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Movie Clone() {
      return new Movie(this);
    }

    /// <summary>Field number for the "MovieId" field.</summary>
    public const int MovieIdFieldNumber = 1;
    private string movieId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MovieId {
      get { return movieId_; }
      set {
        movieId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MovieName" field.</summary>
    public const int MovieNameFieldNumber = 2;
    private string movieName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MovieName {
      get { return movieName_; }
      set {
        movieName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MoviePrice" field.</summary>
    public const int MoviePriceFieldNumber = 3;
    private string moviePrice_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MoviePrice {
      get { return moviePrice_; }
      set {
        moviePrice_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Movie);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Movie other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MovieId != other.MovieId) return false;
      if (MovieName != other.MovieName) return false;
      if (MoviePrice != other.MoviePrice) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MovieId.Length != 0) hash ^= MovieId.GetHashCode();
      if (MovieName.Length != 0) hash ^= MovieName.GetHashCode();
      if (MoviePrice.Length != 0) hash ^= MoviePrice.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (MovieId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MovieId);
      }
      if (MovieName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MovieName);
      }
      if (MoviePrice.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MoviePrice);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MovieId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MovieId);
      }
      if (MovieName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MovieName);
      }
      if (MoviePrice.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MoviePrice);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MovieId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MovieId);
      }
      if (MovieName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MovieName);
      }
      if (MoviePrice.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MoviePrice);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Movie other) {
      if (other == null) {
        return;
      }
      if (other.MovieId.Length != 0) {
        MovieId = other.MovieId;
      }
      if (other.MovieName.Length != 0) {
        MovieName = other.MovieName;
      }
      if (other.MoviePrice.Length != 0) {
        MoviePrice = other.MoviePrice;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            MovieId = input.ReadString();
            break;
          }
          case 18: {
            MovieName = input.ReadString();
            break;
          }
          case 26: {
            MoviePrice = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            MovieId = input.ReadString();
            break;
          }
          case 18: {
            MovieName = input.ReadString();
            break;
          }
          case 26: {
            MoviePrice = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
