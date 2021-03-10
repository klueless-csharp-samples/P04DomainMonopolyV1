DddResourceBuilder.new
  .init
  .resource_key('action:game:sort-players')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
