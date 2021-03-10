DddResourceBuilder.new
  .init
  .resource_key('action:card:follow-instructions')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
